
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tpActualizar = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.tbcCRUD.SuspendLayout();
            this.tpCrear.SuspendLayout();
            this.tpActualizar.SuspendLayout();
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
            this.tpCrear.Controls.Add(this.btnGuardar);
            this.tpCrear.Controls.Add(this.textBox4);
            this.tpCrear.Controls.Add(this.textBox3);
            this.tpCrear.Controls.Add(this.textBox2);
            this.tpCrear.Controls.Add(this.textBox1);
            this.tpCrear.Controls.Add(this.lblTelefono);
            this.tpCrear.Controls.Add(this.lblApellido);
            this.tpCrear.Controls.Add(this.lblCedula);
            this.tpCrear.Controls.Add(this.lblNombre);
            this.tpCrear.Location = new System.Drawing.Point(4, 22);
            this.tpCrear.Name = "tpCrear";
            this.tpCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrear.Size = new System.Drawing.Size(768, 400);
            this.tpCrear.TabIndex = 0;
            this.tpCrear.Text = "Registro";
            this.tpCrear.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(359, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(334, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(193, 196);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(45, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Celular: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(193, 158);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(193, 84);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(193, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCRUD;
        private System.Windows.Forms.TabPage tpCrear;
        private System.Windows.Forms.TabPage tpActualizar;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
    }
}

