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

namespace Proyecto_Final_Lab_BDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        static bool esCorreoValido(string correo)
        {
            string patron = @"/^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            Regex rx = new Regex(patron, RegexOptions.IgnoreCase); //constructor recibe la regex y una opción preestablecida, que en este caso indica que será caseSensitive.
            return rx.IsMatch(correo); //rx.IsMatch compara la regex del constructor con la que pasamos por este parametro
        }
        
    }
}
