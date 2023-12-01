
namespace Proyecto_Final_Lab_BDI
{
    partial class Form1
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
            this.tbcCRUD = new System.Windows.Forms.TabControl();
            this.tpCrear = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tpActualizar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTituloContacto = new System.Windows.Forms.Label();
            this.pnDatosCliente = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblSubTituloDatos = new System.Windows.Forms.Label();
            this.txtCelular = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCorreo = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCedula = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtNombre = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtApellido = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.tbcCRUD.SuspendLayout();
            this.tpCrear.SuspendLayout();
            this.tpActualizar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCRUD
            // 
            this.tbcCRUD.Controls.Add(this.tpCrear);
            this.tbcCRUD.Controls.Add(this.tpActualizar);
            this.tbcCRUD.Controls.Add(this.tpEliminar);
            this.tbcCRUD.Controls.Add(this.tpConsultar);
            this.tbcCRUD.Location = new System.Drawing.Point(12, 12);
            this.tbcCRUD.Name = "tbcCRUD";
            this.tbcCRUD.SelectedIndex = 0;
            this.tbcCRUD.Size = new System.Drawing.Size(776, 426);
            this.tbcCRUD.TabIndex = 0;
            // 
            // tpCrear
            // 
            this.tpCrear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tpCrear.Controls.Add(this.pnDatosCliente);
            this.tpCrear.Controls.Add(this.panel2);
            this.tpCrear.Controls.Add(this.lblTitulo);
            this.tpCrear.Controls.Add(this.btnGuardar);
            this.tpCrear.Location = new System.Drawing.Point(4, 22);
            this.tpCrear.Name = "tpCrear";
            this.tpCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrear.Size = new System.Drawing.Size(768, 400);
            this.tpCrear.TabIndex = 0;
            this.tpCrear.Text = "Registro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(287, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 20);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "REGISTRAR UN CLIENTE";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCorreo.Location = new System.Drawing.Point(13, 91);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(100, 13);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo Electrónico: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(335, 266);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTelefono.Location = new System.Drawing.Point(13, 53);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(45, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Celular: ";
            // 
            // tpActualizar
            // 
            this.tpActualizar.Controls.Add(this.button2);
            this.tpActualizar.Controls.Add(this.textBox5);
            this.tpActualizar.Controls.Add(this.label5);
            this.tpActualizar.Location = new System.Drawing.Point(4, 22);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizar.Size = new System.Drawing.Size(768, 400);
            this.tpActualizar.TabIndex = 1;
            this.tpActualizar.Text = "Actualizar Datos";
            this.tpActualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(231, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // tpEliminar
            // 
            this.tpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Size = new System.Drawing.Size(768, 400);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar Registros";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // tpConsultar
            // 
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Size = new System.Drawing.Size(768, 400);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar Datos";
            this.tpConsultar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtCelular);
            this.panel2.Controls.Add(this.lblSubTituloContacto);
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Controls.Add(this.lblCorreo);
            this.panel2.Location = new System.Drawing.Point(451, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 195);
            this.panel2.TabIndex = 14;
            // 
            // lblSubTituloContacto
            // 
            this.lblSubTituloContacto.AutoSize = true;
            this.lblSubTituloContacto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubTituloContacto.Location = new System.Drawing.Point(59, 17);
            this.lblSubTituloContacto.Name = "lblSubTituloContacto";
            this.lblSubTituloContacto.Size = new System.Drawing.Size(112, 13);
            this.lblSubTituloContacto.TabIndex = 15;
            this.lblSubTituloContacto.Text = "INFO DE CONTACTO";
            // 
            // pnDatosCliente
            // 
            this.pnDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDatosCliente.Controls.Add(this.txtApellido);
            this.pnDatosCliente.Controls.Add(this.txtNombre);
            this.pnDatosCliente.Controls.Add(this.txtCedula);
            this.pnDatosCliente.Controls.Add(this.lblSubTituloDatos);
            this.pnDatosCliente.Controls.Add(this.lblCedula);
            this.pnDatosCliente.Controls.Add(this.lblNombre);
            this.pnDatosCliente.Controls.Add(this.lblApellido);
            this.pnDatosCliente.Location = new System.Drawing.Point(72, 63);
            this.pnDatosCliente.Name = "pnDatosCliente";
            this.pnDatosCliente.Size = new System.Drawing.Size(235, 195);
            this.pnDatosCliente.TabIndex = 12;
            this.pnDatosCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDatosCliente_Paint);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellido.Location = new System.Drawing.Point(11, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(12, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCedula.Location = new System.Drawing.Point(12, 53);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula: ";
            this.lblCedula.Click += new System.EventHandler(this.lblCedula_Click);
            // 
            // lblSubTituloDatos
            // 
            this.lblSubTituloDatos.AutoSize = true;
            this.lblSubTituloDatos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubTituloDatos.Location = new System.Drawing.Point(55, 17);
            this.lblSubTituloDatos.Name = "lblSubTituloDatos";
            this.lblSubTituloDatos.Size = new System.Drawing.Size(119, 13);
            this.lblSubTituloDatos.TabIndex = 14;
            this.lblSubTituloDatos.Text = "DATOS PERSONALES";
            // 
            // txtCelular
            // 
            this.txtCelular.ForeColor = System.Drawing.Color.DimGray;
            this.txtCelular.Location = new System.Drawing.Point(119, 50);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PlaceHolder = "Celular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 15;
            this.txtCelular.Text = "Celular";
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(119, 88);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceHolder = "correo@gmail.com";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 16;
            this.txtCorreo.Text = "correo@gmail.com";
            // 
            // txtCedula
            // 
            this.txtCedula.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedula.Location = new System.Drawing.Point(74, 50);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PlaceHolder = "Cedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 17;
            this.txtCedula.Text = "Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(74, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceHolder = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(74, 133);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceHolder = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 19;
            this.txtApellido.Text = "Apellido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCRUD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcCRUD.ResumeLayout(false);
            this.tpCrear.ResumeLayout(false);
            this.tpCrear.PerformLayout();
            this.tpActualizar.ResumeLayout(false);
            this.tpActualizar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnDatosCliente.ResumeLayout(false);
            this.pnDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCRUD;
        private System.Windows.Forms.TabPage tpCrear;
        private System.Windows.Forms.TabPage tpActualizar;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnDatosCliente;
        private System.Windows.Forms.Label lblSubTituloDatos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSubTituloContacto;
        private TxtHolder txtCelular;
        private TxtHolder txtCorreo;
        private TxtHolder txtApellido;
        private TxtHolder txtNombre;
        private TxtHolder txtCedula;
    }
}

