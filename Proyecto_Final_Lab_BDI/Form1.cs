using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Proyecto_Final_Lab_BDI.logica;

namespace Proyecto_Final_Lab_BDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        //------------BTNGuardar DE LA PESTAÑA REGISTRO----------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cedula, numTelefono, resultado;
            string nombre, apellido, correo;
            string correoValido = txtCorreo.Text;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            cedula = int.Parse(txtCedula.Text);
            numTelefono = int.Parse(txtCelular.Text);
                if (!esCorreoValido(correoValido))
                {
                    MessageBox.Show("Introduce una dirección de correo válida", "CORREO", MessageBoxButtons.OK);
                }
                else
                {
                    correo = txtCorreo.Text;
                    resultado = cliente.ingresarCliente(cedula, nombre, apellido, numTelefono, correo);
                    if (resultado > 0) MessageBox.Show("Cliente Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (resultado < 1) MessageBox.Show("No se pudo registrar el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        static bool esCorreoValido(string correo)
        {
            string patron = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            Regex rx = new Regex(patron, RegexOptions.IgnoreCase); //constructor recibe la regex y una opción preestablecida, que en este caso indica que será caseSensitive.
            return rx.IsMatch(correo); //rx.IsMatch compara la regex del constructor con la que pasamos por este parametro
        }
        //------------BTNGuardar DE LA PESTAÑA REGISTRO----------------


        //------------BTNBuscar DE LA PESTAÑA ACTUALIZAR----------------
        private void btnBuscarPorCedula_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int cedula;
            cedula = int.Parse(txtCedulaCliente.Text);
            ds = cliente.consultarCliente(cedula);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Rows[0] indica que nos ubicamos en la fila 0, y ["aniNombre"] representa la columna (también podría ser[0] en vez de aniNombre).

                //ACTIVANDO LOS TXT
                txtCedulaAct.Enabled = true;
                txtNombreAct.Enabled = true;
                txtApellidoAct.Enabled = true;
                txtCelularAct.Enabled = true;
                txtCorreoAct.Enabled = true;
                
                //SETEANDO LA INFO EN TXT
                txtCedulaAct.Text = ds.Tables["ResultadoDatos"].Rows[0][0].ToString();
                txtNombreAct.Text = ds.Tables["ResultadoDatos"].Rows[0][1].ToString();
                txtApellidoAct.Text = ds.Tables["ResultadoDatos"].Rows[0][2].ToString();
                txtCelularAct.Text = ds.Tables["ResultadoDatos"].Rows[0][3].ToString();
                txtCorreoAct.Text = ds.Tables["ResultadoDatos"].Rows[0][4].ToString();
                btnActualizar.Enabled = true;
                MessageBox.Show("Cliente encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //------------BTNBuscar DE LA PESTAÑA ACTUALIZAR----------------

        //------------BTNEliminar DE LA PESTAÑA ELIMINAR----------------
        private void btnEliminarClienteDel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar los datos de este cliente?", "ELIMINAR CLIENTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK) EliminarCliente();
        }
        private void EliminarCliente()
        {
            // Implementa la lógica para eliminar al cliente aquí
            // Por ejemplo, puedes mostrar otro MessageBox o realizar otras operaciones.
            int cedula;
            cedula = int.Parse(txtClienteDel.Text);
            cliente.eliminarCliente(cedula);
            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------BTNEliminar DE LA PESTAÑA ELIMINAR----------------

        //------------BTNACTUALIZAR DE LA PESTAÑA ACTUALIZAR----------------
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int cedula, numTelefono, resultado, busCedula;
            string nombre, apellido, correo;
            string correoValido = txtCorreoAct.Text;
            nombre = txtNombreAct.Text;
            apellido = txtApellidoAct.Text;
            cedula = int.Parse(txtCedulaAct.Text);
            numTelefono = int.Parse(txtCelularAct.Text);
            busCedula = int.Parse(txtCedulaCliente.Text);
            Console.WriteLine("probando" + busCedula);
            correo = txtCorreoAct.Text;
            resultado = cliente.actualizarCliente(busCedula, cedula, nombre, apellido, numTelefono, correo);
            if (resultado > 0) MessageBox.Show("Información actualizada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado < 1) MessageBox.Show("No se pudo actualizar la información", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        //------------BTNACTUALIZAR DE LA PESTAÑA ACTUALIZAR----------------


        //------------BTNBuscar DE LA PESTAÑA ELIMINAR----------------
        private void btnBuscarDel_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int cedula;
            cedula = int.Parse(txtClienteDel.Text);
            ds = cliente.consultarCliente(cedula);
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnEliminarClienteDel.Enabled = true;
                dgvClienteDel.DataSource = ds;
                dgvClienteDel.DataMember = "ResultadoDatos";
                MessageBox.Show("Cliente encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //------------BTNBuscar DE LA PESTAÑA ELIMINAR----------------
    }
}
