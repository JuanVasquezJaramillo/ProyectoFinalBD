
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcCRUD = new System.Windows.Forms.TabControl();
            this.tpCrear = new System.Windows.Forms.TabPage();
            this.pnDatosCliente = new System.Windows.Forms.Panel();
            this.lblSubTituloDatos = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTituloContacto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tpActualizar = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubTituloActualizarInfo = new System.Windows.Forms.Label();
            this.lblCelularAct = new System.Windows.Forms.Label();
            this.lblCorreoAct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubTituloActualizar = new System.Windows.Forms.Label();
            this.lblCedulaAct = new System.Windows.Forms.Label();
            this.lblNombreAct = new System.Windows.Forms.Label();
            this.lblApellidoAct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloActualizar = new System.Windows.Forms.Label();
            this.btnBuscarPorCedula = new System.Windows.Forms.Button();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminarClienteDel = new System.Windows.Forms.Button();
            this.dgvClienteDel = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTituloEliminarCliente = new System.Windows.Forms.Label();
            this.btnBuscarDel = new System.Windows.Forms.Button();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.dgvClientesConsulta = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTituloConsultarClientes = new System.Windows.Forms.Label();
            this.btnBuscarClientesCon = new System.Windows.Forms.Button();
            this.tpReportes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtituloReportes2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvReporte3 = new System.Windows.Forms.DataGridView();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.dgvReporte2 = new System.Windows.Forms.DataGridView();
            this.dgvReporte1 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTituloReportes = new System.Windows.Forms.Label();
            this.lblSubTituloReportes = new System.Windows.Forms.Label();
            this.btnVerReporte2 = new System.Windows.Forms.Button();
            this.btnVerReporte3 = new System.Windows.Forms.Button();
            this.txtApellido = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtNombre = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCedula = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCorreo = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCelular = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCorreoAct = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCelularAct = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtApellidoAct = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtNombreAct = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCedulaAct = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtCedulaCliente = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtClienteDel = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.txtBuscarClientesCon = new Proyecto_Final_Lab_BDI.TxtHolder();
            this.tbcCRUD.SuspendLayout();
            this.tpCrear.SuspendLayout();
            this.pnDatosCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpActualizar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteDel)).BeginInit();
            this.panel5.SuspendLayout();
            this.tpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesConsulta)).BeginInit();
            this.panel6.SuspendLayout();
            this.tpReportes.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCRUD
            // 
            this.tbcCRUD.Controls.Add(this.tpCrear);
            this.tbcCRUD.Controls.Add(this.tpActualizar);
            this.tbcCRUD.Controls.Add(this.tpEliminar);
            this.tbcCRUD.Controls.Add(this.tpConsultar);
            this.tbcCRUD.Controls.Add(this.tpReportes);
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
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCedula.Location = new System.Drawing.Point(12, 53);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula: ";
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(317, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 51);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tpActualizar
            // 
            this.tpActualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tpActualizar.Controls.Add(this.btnActualizar);
            this.tpActualizar.Controls.Add(this.panel4);
            this.tpActualizar.Controls.Add(this.panel3);
            this.tpActualizar.Controls.Add(this.panel1);
            this.tpActualizar.Location = new System.Drawing.Point(4, 22);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizar.Size = new System.Drawing.Size(768, 400);
            this.tpActualizar.TabIndex = 1;
            this.tpActualizar.Text = "Actualizar Datos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Honeydew;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(347, 371);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtCorreoAct);
            this.panel4.Controls.Add(this.txtCelularAct);
            this.panel4.Controls.Add(this.lblSubTituloActualizarInfo);
            this.panel4.Controls.Add(this.lblCelularAct);
            this.panel4.Controls.Add(this.lblCorreoAct);
            this.panel4.Location = new System.Drawing.Point(469, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 195);
            this.panel4.TabIndex = 15;
            // 
            // lblSubTituloActualizarInfo
            // 
            this.lblSubTituloActualizarInfo.AutoSize = true;
            this.lblSubTituloActualizarInfo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubTituloActualizarInfo.Location = new System.Drawing.Point(59, 17);
            this.lblSubTituloActualizarInfo.Name = "lblSubTituloActualizarInfo";
            this.lblSubTituloActualizarInfo.Size = new System.Drawing.Size(112, 13);
            this.lblSubTituloActualizarInfo.TabIndex = 15;
            this.lblSubTituloActualizarInfo.Text = "INFO DE CONTACTO";
            // 
            // lblCelularAct
            // 
            this.lblCelularAct.AutoSize = true;
            this.lblCelularAct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCelularAct.Location = new System.Drawing.Point(13, 53);
            this.lblCelularAct.Name = "lblCelularAct";
            this.lblCelularAct.Size = new System.Drawing.Size(45, 13);
            this.lblCelularAct.TabIndex = 3;
            this.lblCelularAct.Text = "Celular: ";
            // 
            // lblCorreoAct
            // 
            this.lblCorreoAct.AutoSize = true;
            this.lblCorreoAct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCorreoAct.Location = new System.Drawing.Point(13, 91);
            this.lblCorreoAct.Name = "lblCorreoAct";
            this.lblCorreoAct.Size = new System.Drawing.Size(100, 13);
            this.lblCorreoAct.TabIndex = 9;
            this.lblCorreoAct.Text = "Correo Electrónico: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtApellidoAct);
            this.panel3.Controls.Add(this.txtNombreAct);
            this.panel3.Controls.Add(this.txtCedulaAct);
            this.panel3.Controls.Add(this.lblSubTituloActualizar);
            this.panel3.Controls.Add(this.lblCedulaAct);
            this.panel3.Controls.Add(this.lblNombreAct);
            this.panel3.Controls.Add(this.lblApellidoAct);
            this.panel3.Location = new System.Drawing.Point(66, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 195);
            this.panel3.TabIndex = 13;
            // 
            // lblSubTituloActualizar
            // 
            this.lblSubTituloActualizar.AutoSize = true;
            this.lblSubTituloActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubTituloActualizar.Location = new System.Drawing.Point(55, 17);
            this.lblSubTituloActualizar.Name = "lblSubTituloActualizar";
            this.lblSubTituloActualizar.Size = new System.Drawing.Size(119, 13);
            this.lblSubTituloActualizar.TabIndex = 14;
            this.lblSubTituloActualizar.Text = "DATOS PERSONALES";
            // 
            // lblCedulaAct
            // 
            this.lblCedulaAct.AutoSize = true;
            this.lblCedulaAct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCedulaAct.Location = new System.Drawing.Point(12, 53);
            this.lblCedulaAct.Name = "lblCedulaAct";
            this.lblCedulaAct.Size = new System.Drawing.Size(46, 13);
            this.lblCedulaAct.TabIndex = 1;
            this.lblCedulaAct.Text = "Cedula: ";
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombreAct.Location = new System.Drawing.Point(12, 91);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.Size = new System.Drawing.Size(50, 13);
            this.lblNombreAct.TabIndex = 0;
            this.lblNombreAct.Text = "Nombre: ";
            // 
            // lblApellidoAct
            // 
            this.lblApellidoAct.AutoSize = true;
            this.lblApellidoAct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoAct.Location = new System.Drawing.Point(11, 136);
            this.lblApellidoAct.Name = "lblApellidoAct";
            this.lblApellidoAct.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoAct.TabIndex = 2;
            this.lblApellidoAct.Text = "Apellido:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTituloActualizar);
            this.panel1.Controls.Add(this.btnBuscarPorCedula);
            this.panel1.Controls.Add(this.txtCedulaCliente);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 159);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloActualizar
            // 
            this.lblTituloActualizar.AutoSize = true;
            this.lblTituloActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloActualizar.Location = new System.Drawing.Point(244, 34);
            this.lblTituloActualizar.Name = "lblTituloActualizar";
            this.lblTituloActualizar.Size = new System.Drawing.Size(267, 20);
            this.lblTituloActualizar.TabIndex = 2;
            this.lblTituloActualizar.Text = "ACTUALIZAR DATOS DE CLIENTE";
            // 
            // btnBuscarPorCedula
            // 
            this.btnBuscarPorCedula.BackColor = System.Drawing.Color.Honeydew;
            this.btnBuscarPorCedula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPorCedula.Location = new System.Drawing.Point(336, 93);
            this.btnBuscarPorCedula.Name = "btnBuscarPorCedula";
            this.btnBuscarPorCedula.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorCedula.TabIndex = 1;
            this.btnBuscarPorCedula.Text = "Buscar";
            this.btnBuscarPorCedula.UseVisualStyleBackColor = false;
            this.btnBuscarPorCedula.Click += new System.EventHandler(this.btnBuscarPorCedula_Click);
            // 
            // tpEliminar
            // 
            this.tpEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tpEliminar.Controls.Add(this.btnEliminarClienteDel);
            this.tpEliminar.Controls.Add(this.dgvClienteDel);
            this.tpEliminar.Controls.Add(this.panel5);
            this.tpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Size = new System.Drawing.Size(768, 400);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar Registros";
            // 
            // btnEliminarClienteDel
            // 
            this.btnEliminarClienteDel.BackColor = System.Drawing.Color.Honeydew;
            this.btnEliminarClienteDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarClienteDel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminarClienteDel.Location = new System.Drawing.Point(280, 359);
            this.btnEliminarClienteDel.Name = "btnEliminarClienteDel";
            this.btnEliminarClienteDel.Size = new System.Drawing.Size(187, 23);
            this.btnEliminarClienteDel.TabIndex = 3;
            this.btnEliminarClienteDel.Text = "Borrar cliente";
            this.btnEliminarClienteDel.UseVisualStyleBackColor = false;
            this.btnEliminarClienteDel.Click += new System.EventHandler(this.btnEliminarClienteDel_Click);
            // 
            // dgvClienteDel
            // 
            this.dgvClienteDel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClienteDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteDel.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClienteDel.Location = new System.Drawing.Point(134, 169);
            this.dgvClienteDel.Name = "dgvClienteDel";
            this.dgvClienteDel.Size = new System.Drawing.Size(478, 184);
            this.dgvClienteDel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTituloEliminarCliente);
            this.panel5.Controls.Add(this.btnBuscarDel);
            this.panel5.Controls.Add(this.txtClienteDel);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(768, 159);
            this.panel5.TabIndex = 1;
            // 
            // lblTituloEliminarCliente
            // 
            this.lblTituloEliminarCliente.AutoSize = true;
            this.lblTituloEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEliminarCliente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloEliminarCliente.Location = new System.Drawing.Point(215, 32);
            this.lblTituloEliminarCliente.Name = "lblTituloEliminarCliente";
            this.lblTituloEliminarCliente.Size = new System.Drawing.Size(318, 20);
            this.lblTituloEliminarCliente.TabIndex = 2;
            this.lblTituloEliminarCliente.Text = "ELIMINAR CLIENTE DE BASE DE DATOS";
            // 
            // btnBuscarDel
            // 
            this.btnBuscarDel.BackColor = System.Drawing.Color.Honeydew;
            this.btnBuscarDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDel.Location = new System.Drawing.Point(334, 104);
            this.btnBuscarDel.Name = "btnBuscarDel";
            this.btnBuscarDel.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDel.TabIndex = 1;
            this.btnBuscarDel.Text = "Buscar";
            this.btnBuscarDel.UseVisualStyleBackColor = false;
            this.btnBuscarDel.Click += new System.EventHandler(this.btnBuscarDel_Click);
            // 
            // tpConsultar
            // 
            this.tpConsultar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tpConsultar.Controls.Add(this.dgvClientesConsulta);
            this.tpConsultar.Controls.Add(this.panel6);
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Size = new System.Drawing.Size(768, 400);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar Datos";
            // 
            // dgvClientesConsulta
            // 
            this.dgvClientesConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientesConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesConsulta.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientesConsulta.Location = new System.Drawing.Point(139, 168);
            this.dgvClientesConsulta.Name = "dgvClientesConsulta";
            this.dgvClientesConsulta.Size = new System.Drawing.Size(478, 184);
            this.dgvClientesConsulta.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblTituloConsultarClientes);
            this.panel6.Controls.Add(this.btnBuscarClientesCon);
            this.panel6.Controls.Add(this.txtBuscarClientesCon);
            this.panel6.Location = new System.Drawing.Point(4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(768, 159);
            this.panel6.TabIndex = 2;
            // 
            // lblTituloConsultarClientes
            // 
            this.lblTituloConsultarClientes.AutoSize = true;
            this.lblTituloConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultarClientes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloConsultarClientes.Location = new System.Drawing.Point(197, 33);
            this.lblTituloConsultarClientes.Name = "lblTituloConsultarClientes";
            this.lblTituloConsultarClientes.Size = new System.Drawing.Size(333, 20);
            this.lblTituloConsultarClientes.TabIndex = 2;
            this.lblTituloConsultarClientes.Text = "CONSULTAR INFORMACIÓN DE CLIENTES";
            // 
            // btnBuscarClientesCon
            // 
            this.btnBuscarClientesCon.BackColor = System.Drawing.Color.Honeydew;
            this.btnBuscarClientesCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClientesCon.Location = new System.Drawing.Point(334, 104);
            this.btnBuscarClientesCon.Name = "btnBuscarClientesCon";
            this.btnBuscarClientesCon.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarClientesCon.TabIndex = 1;
            this.btnBuscarClientesCon.Text = "Buscar";
            this.btnBuscarClientesCon.UseVisualStyleBackColor = false;
            this.btnBuscarClientesCon.Click += new System.EventHandler(this.btnBuscarClientesCon_Click);
            // 
            // tpReportes
            // 
            this.tpReportes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tpReportes.Controls.Add(this.label1);
            this.tpReportes.Controls.Add(this.lblSubtituloReportes2);
            this.tpReportes.Controls.Add(this.panel8);
            this.tpReportes.Controls.Add(this.panel7);
            this.tpReportes.Controls.Add(this.lblSubTituloReportes);
            this.tpReportes.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tpReportes.Location = new System.Drawing.Point(4, 22);
            this.tpReportes.Name = "tpReportes";
            this.tpReportes.Size = new System.Drawing.Size(768, 400);
            this.tpReportes.TabIndex = 4;
            this.tpReportes.Text = "Reportes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(557, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre de los destinos \r\nde los paquetes \r\ncon costo menor de 350000$";
            // 
            // lblSubtituloReportes2
            // 
            this.lblSubtituloReportes2.AutoSize = true;
            this.lblSubtituloReportes2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubtituloReportes2.Location = new System.Drawing.Point(298, 67);
            this.lblSubtituloReportes2.Name = "lblSubtituloReportes2";
            this.lblSubtituloReportes2.Size = new System.Drawing.Size(145, 39);
            this.lblSubtituloReportes2.TabIndex = 16;
            this.lblSubtituloReportes2.Text = "Nombre del cliente \r\ny cantidad de reservas \r\nhechas por él en el año 2023";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.btnVerReporte3);
            this.panel8.Controls.Add(this.btnVerReporte2);
            this.panel8.Controls.Add(this.dgvReporte3);
            this.panel8.Controls.Add(this.btnVerReporte);
            this.panel8.Controls.Add(this.dgvReporte2);
            this.panel8.Controls.Add(this.dgvReporte1);
            this.panel8.Location = new System.Drawing.Point(19, 118);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(742, 218);
            this.panel8.TabIndex = 14;
            // 
            // dgvReporte3
            // 
            this.dgvReporte3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReporte3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte3.Location = new System.Drawing.Point(494, 26);
            this.dgvReporte3.Name = "dgvReporte3";
            this.dgvReporte3.Size = new System.Drawing.Size(223, 150);
            this.dgvReporte3.TabIndex = 2;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.BackColor = System.Drawing.Color.Honeydew;
            this.btnVerReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerReporte.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnVerReporte.Location = new System.Drawing.Point(68, 182);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte.TabIndex = 17;
            this.btnVerReporte.Text = "VER";
            this.btnVerReporte.UseVisualStyleBackColor = false;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // dgvReporte2
            // 
            this.dgvReporte2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReporte2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte2.Location = new System.Drawing.Point(252, 26);
            this.dgvReporte2.Name = "dgvReporte2";
            this.dgvReporte2.Size = new System.Drawing.Size(211, 150);
            this.dgvReporte2.TabIndex = 1;
            // 
            // dgvReporte1
            // 
            this.dgvReporte1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReporte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte1.Location = new System.Drawing.Point(13, 26);
            this.dgvReporte1.Name = "dgvReporte1";
            this.dgvReporte1.Size = new System.Drawing.Size(209, 150);
            this.dgvReporte1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblTituloReportes);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(758, 49);
            this.panel7.TabIndex = 1;
            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloReportes.Location = new System.Drawing.Point(303, 18);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(163, 20);
            this.lblTituloReportes.TabIndex = 2;
            this.lblTituloReportes.Text = "REPORTES VARIOS";
            // 
            // lblSubTituloReportes
            // 
            this.lblSubTituloReportes.AutoSize = true;
            this.lblSubTituloReportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSubTituloReportes.Location = new System.Drawing.Point(73, 67);
            this.lblSubTituloReportes.Name = "lblSubTituloReportes";
            this.lblSubTituloReportes.Size = new System.Drawing.Size(58, 39);
            this.lblSubTituloReportes.TabIndex = 14;
            this.lblSubTituloReportes.Text = "Cantidad \r\nde clientes\r\nregistrados\r\n";
            // 
            // btnVerReporte2
            // 
            this.btnVerReporte2.BackColor = System.Drawing.Color.Honeydew;
            this.btnVerReporte2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerReporte2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnVerReporte2.Location = new System.Drawing.Point(322, 182);
            this.btnVerReporte2.Name = "btnVerReporte2";
            this.btnVerReporte2.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte2.TabIndex = 18;
            this.btnVerReporte2.Text = "VER";
            this.btnVerReporte2.UseVisualStyleBackColor = false;
            this.btnVerReporte2.Click += new System.EventHandler(this.btnVerReporte2_Click);
            // 
            // btnVerReporte3
            // 
            this.btnVerReporte3.BackColor = System.Drawing.Color.Honeydew;
            this.btnVerReporte3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerReporte3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnVerReporte3.Location = new System.Drawing.Point(571, 182);
            this.btnVerReporte3.Name = "btnVerReporte3";
            this.btnVerReporte3.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte3.TabIndex = 19;
            this.btnVerReporte3.Text = "VER";
            this.btnVerReporte3.UseVisualStyleBackColor = false;
            this.btnVerReporte3.Click += new System.EventHandler(this.btnVerReporte3_Click);
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
            // txtCorreoAct
            // 
            this.txtCorreoAct.Enabled = false;
            this.txtCorreoAct.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreoAct.Location = new System.Drawing.Point(119, 88);
            this.txtCorreoAct.Name = "txtCorreoAct";
            this.txtCorreoAct.PlaceHolder = "correo@gmail.com";
            this.txtCorreoAct.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoAct.TabIndex = 16;
            this.txtCorreoAct.Text = "correo@gmail.com";
            // 
            // txtCelularAct
            // 
            this.txtCelularAct.Enabled = false;
            this.txtCelularAct.ForeColor = System.Drawing.Color.DimGray;
            this.txtCelularAct.Location = new System.Drawing.Point(119, 50);
            this.txtCelularAct.Name = "txtCelularAct";
            this.txtCelularAct.PlaceHolder = "Celular";
            this.txtCelularAct.Size = new System.Drawing.Size(100, 20);
            this.txtCelularAct.TabIndex = 15;
            this.txtCelularAct.Text = "Celular";
            // 
            // txtApellidoAct
            // 
            this.txtApellidoAct.Enabled = false;
            this.txtApellidoAct.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoAct.Location = new System.Drawing.Point(74, 133);
            this.txtApellidoAct.Name = "txtApellidoAct";
            this.txtApellidoAct.PlaceHolder = "Apellido";
            this.txtApellidoAct.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAct.TabIndex = 19;
            this.txtApellidoAct.Text = "Apellido";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Enabled = false;
            this.txtNombreAct.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreAct.Location = new System.Drawing.Point(74, 88);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.PlaceHolder = "Nombre";
            this.txtNombreAct.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAct.TabIndex = 18;
            this.txtNombreAct.Text = "Nombre";
            // 
            // txtCedulaAct
            // 
            this.txtCedulaAct.Enabled = false;
            this.txtCedulaAct.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaAct.Location = new System.Drawing.Point(74, 50);
            this.txtCedulaAct.Name = "txtCedulaAct";
            this.txtCedulaAct.PlaceHolder = "Cedula";
            this.txtCedulaAct.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaAct.TabIndex = 17;
            this.txtCedulaAct.Text = "Cedula";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaCliente.Location = new System.Drawing.Point(278, 67);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.PlaceHolder = "Buscar...";
            this.txtCedulaCliente.Size = new System.Drawing.Size(187, 20);
            this.txtCedulaCliente.TabIndex = 0;
            this.txtCedulaCliente.Text = "Buscar...";
            // 
            // txtClienteDel
            // 
            this.txtClienteDel.ForeColor = System.Drawing.Color.DimGray;
            this.txtClienteDel.Location = new System.Drawing.Point(278, 67);
            this.txtClienteDel.Name = "txtClienteDel";
            this.txtClienteDel.PlaceHolder = "Buscar...";
            this.txtClienteDel.Size = new System.Drawing.Size(187, 20);
            this.txtClienteDel.TabIndex = 0;
            this.txtClienteDel.Text = "Buscar...";
            // 
            // txtBuscarClientesCon
            // 
            this.txtBuscarClientesCon.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarClientesCon.Location = new System.Drawing.Point(278, 67);
            this.txtBuscarClientesCon.Name = "txtBuscarClientesCon";
            this.txtBuscarClientesCon.PlaceHolder = "Buscar...";
            this.txtBuscarClientesCon.Size = new System.Drawing.Size(187, 20);
            this.txtBuscarClientesCon.TabIndex = 0;
            this.txtBuscarClientesCon.Text = "Buscar...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AppCliente";
            this.tbcCRUD.ResumeLayout(false);
            this.tpCrear.ResumeLayout(false);
            this.tpCrear.PerformLayout();
            this.pnDatosCliente.ResumeLayout(false);
            this.pnDatosCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpActualizar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteDel)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tpConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesConsulta)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpReportes.ResumeLayout(false);
            this.tpReportes.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSubTituloContacto;
        private TxtHolder txtCelular;
        private TxtHolder txtCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloActualizar;
        private System.Windows.Forms.Button btnBuscarPorCedula;
        private TxtHolder txtCedulaCliente;
        private System.Windows.Forms.Panel pnDatosCliente;
        private TxtHolder txtApellido;
        private TxtHolder txtNombre;
        private TxtHolder txtCedula;
        private System.Windows.Forms.Label lblSubTituloDatos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel4;
        private TxtHolder txtCorreoAct;
        private TxtHolder txtCelularAct;
        private System.Windows.Forms.Label lblSubTituloActualizarInfo;
        private System.Windows.Forms.Label lblCelularAct;
        private System.Windows.Forms.Label lblCorreoAct;
        private System.Windows.Forms.Panel panel3;
        private TxtHolder txtApellidoAct;
        private TxtHolder txtNombreAct;
        private TxtHolder txtCedulaAct;
        private System.Windows.Forms.Label lblSubTituloActualizar;
        private System.Windows.Forms.Label lblCedulaAct;
        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.Label lblApellidoAct;
        private System.Windows.Forms.Button btnEliminarClienteDel;
        private System.Windows.Forms.DataGridView dgvClienteDel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTituloEliminarCliente;
        private System.Windows.Forms.Button btnBuscarDel;
        private TxtHolder txtClienteDel;
        private System.Windows.Forms.DataGridView dgvClientesConsulta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTituloConsultarClientes;
        private System.Windows.Forms.Button btnBuscarClientesCon;
        private TxtHolder txtBuscarClientesCon;
        private System.Windows.Forms.TabPage tpReportes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTituloReportes;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Label lblSubtituloReportes2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvReporte1;
        private System.Windows.Forms.Label lblSubTituloReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporte3;
        private System.Windows.Forms.DataGridView dgvReporte2;
        private System.Windows.Forms.Button btnVerReporte3;
        private System.Windows.Forms.Button btnVerReporte2;
    }
}

