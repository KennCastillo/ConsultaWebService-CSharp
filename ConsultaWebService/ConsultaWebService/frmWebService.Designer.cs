namespace ConsultaWebService
{
    partial class frmWebService
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebService));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rbConsultar = new System.Windows.Forms.RadioButton();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(95, 106);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(25, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(75, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(51, 110);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salario:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(95, 144);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Ejecutar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rbConsultar
            // 
            this.rbConsultar.AutoSize = true;
            this.rbConsultar.Location = new System.Drawing.Point(12, 12);
            this.rbConsultar.Name = "rbConsultar";
            this.rbConsultar.Size = new System.Drawing.Size(69, 17);
            this.rbConsultar.TabIndex = 7;
            this.rbConsultar.TabStop = true;
            this.rbConsultar.Text = "Consultar";
            this.rbConsultar.UseVisualStyleBackColor = true;
            this.rbConsultar.CheckedChanged += new System.EventHandler(this.rbConsultar_CheckedChanged);
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.Location = new System.Drawing.Point(87, 12);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(62, 17);
            this.rbAgregar.TabIndex = 8;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar";
            this.rbAgregar.UseVisualStyleBackColor = true;
            this.rbAgregar.CheckedChanged += new System.EventHandler(this.rbAgregar_CheckedChanged);
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(155, 12);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 9;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbModificar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(229, 12);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(61, 17);
            this.rbEliminar.TabIndex = 10;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // frmWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 194);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.rbAgregar);
            this.Controls.Add(this.rbConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Web Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbConsultar;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
    }
}

