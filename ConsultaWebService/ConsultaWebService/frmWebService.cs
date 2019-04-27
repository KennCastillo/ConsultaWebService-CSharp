using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Dynamic;

namespace ConsultaWebService
{
    public partial class frmWebService : Form
    {
        private string urlGlobal = "http://localhost:7801/";        

        public frmWebService()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbConsultar.Checked = true;
        }

        //CONSULTAR
        public void read(string id)
        {
            //string url = urlGlobal + id;
            //WebRequest request = WebRequest.Create(url);
            //var json = new WebClient().DownloadString(url);
            //dynamic m = JsonConvert.DeserializeObject(json);

            //txtNombre.Text = m.name;
            //txtSalario.Text = m.salary;

            WebRequest peticion = WebRequest.Create(urlGlobal + id);            
            peticion.Method = "GET";
            try
            {
                HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;
                var streamReader = new StreamReader(respuesta.GetResponseStream());
                string s = streamReader.ReadToEnd();
                dynamic arr = JsonConvert.DeserializeObject(s);
                txtNombre.Text = arr.name;
                txtSalario.Text = arr.salary;
            }catch (Exception ex){
                MessageBox.Show("No se obtuvo una respuesta del revidor: " + ex.Message.ToString());
            }
            
            //using (var streamReader = new StreamReader(respuesta.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    dynamic arr = JsonConvert.DeserializeObject(result);
            //    txtNombre.Text = arr[1];
            //    txtSalario.Text = arr[2];
            //}
        }

        //INSERTAR
        public void create(string nombre, string salario)
        {
            dynamic campos = new ExpandoObject();
            campos.id = 0;
            campos.name = nombre;
            campos.salary = salario;

            string json_data = JsonConvert.SerializeObject(campos);            

            //Se configura la petición.
            HttpWebRequest peticion = WebRequest.Create(urlGlobal) as HttpWebRequest;
            peticion.ContentType = "application/json; charset=utf-8";
            peticion.Method = "POST";

            using (var streamWriter = new StreamWriter(peticion.GetRequestStream()))
            {
                streamWriter.Write(json_data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;
                MessageBox.Show("Trabajador agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                MessageBox.Show("No se pudo agregar el trabajador, Error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //MODIFICAR
        public void update(string id, string nombre, string salario)
        {
            dynamic campos = new ExpandoObject();
            //campos.id = id;
            campos.name = nombre;
            campos.salary = salario;

            string json_data = JsonConvert.SerializeObject(campos);            

            WebRequest peticion = WebRequest.Create(urlGlobal + id);
            peticion.ContentType = "application/json; charset=utf-8";
            peticion.Method = "PUT";

            using (var streamWriter = new StreamWriter(peticion.GetRequestStream()))
            {
                streamWriter.Write(json_data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;               
                MessageBox.Show("Trabajador modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                MessageBox.Show("No se pudo modificar el trabajador, Error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ELIMINAR
        public void delete(string id)
        {
            WebRequest peticion = WebRequest.Create(urlGlobal + id);
            peticion.Method = "DELETE";
            try
            {
                HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;
                MessageBox.Show("Trabajador eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                MessageBox.Show("No se pudo agregar el trabajador, Error: " + ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (rbConsultar.Checked)
            {
                if (txtId.Text != "")
                {
                    read(txtId.Text);
                }
                else
                {
                    MessageBox.Show("Favor de capturar el ID del trabajador que desea consultar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }

            if (rbAgregar.Checked)
            {
                if (txtNombre.Text == "" || txtSalario.Text == "")
                {
                    MessageBox.Show("Favor de llenar los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                else
                {
                    create(txtNombre.Text, txtSalario.Text);
                }                
            }

            if (rbModificar.Checked)
            {
                if (txtNombre.Text == "" || txtSalario.Text == "" || txtId.Text == "")
                {
                    MessageBox.Show("Favor de llenar los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                else
                {
                    update(txtId.Text, txtNombre.Text, txtSalario.Text);
                }                
            }

            if (rbEliminar.Checked)
            {
                if (txtId.Text != "")
                {
                    delete(txtId.Text);
                }
                else
                {
                    MessageBox.Show("Favor de capturar el ID del trabajador que desea eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }            
        }

        private void rbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsultar.Checked)
            {
                txtId.ReadOnly = false;
                txtNombre.ReadOnly = true;
                txtSalario.ReadOnly = true;
                clearTextBox();
            }
        }

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgregar.Checked)
            {
                txtId.ReadOnly = true;
                txtNombre.ReadOnly = false;
                txtSalario.ReadOnly = false;
                clearTextBox();
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificar.Checked)
            {
                txtId.ReadOnly = false;
                txtNombre.ReadOnly = false;
                txtSalario.ReadOnly = false;
            }
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEliminar.Checked)
            {
                txtId.ReadOnly = false;
                txtNombre.ReadOnly = true;
                txtSalario.ReadOnly = true;
                clearTextBox();
            }
        }

        private void clearTextBox()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtSalario.Text = "";
        }
    }
    
}
