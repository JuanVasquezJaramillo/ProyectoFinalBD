using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_Final_Lab_BDI.accesoDatos;

namespace Proyecto_Final_Lab_BDI.logica
{
    class Cliente
    {
        Datos objDatos = new Datos();
        public DataSet consultarCliente(int perCedula)
        {
            DataSet localDataSet = new DataSet();
            string consulta = $"SELECT perCedula as Cedula, perNombre as Nombre, perApellido as Apellido, perNumTelefono as Celular, perCorreo as Correo FROM Cliente WHERE perCedula ={perCedula}";
            localDataSet = objDatos.ejecutarSelect(consulta);
            return localDataSet;
        }
        public int ingresarCliente(int perCedula, string perNombre, string perApellido, Int32 perNumTelefono, string perCorreo)
        {
            string consulta = "insert into Cliente(perCedula, perNombre, perApellido, perNumTelefono, perCorreo)values " +
                "("
                + perCedula
                + " , ' "
                + perNombre
                + " ' , ' "
                + perApellido
                + " ' ,  "
                + perNumTelefono
                + " , ' "
                + perCorreo
                + " ' )";
                return objDatos.ejecutarDML(consulta);
        }
        public int actualizarCliente(int perCedulaBus, int perCedula, string perNombre, string perApellido, Int32 perNumTelefono, string perCorreo)
        {
            string consulta = "UPDATE Cliente "
                + "SET perCedula = "
                + perCedula 
                + " , "
                + "perNombre = "
                + " ' "
                + perNombre
                + " ' , "
                + "perApellido = "
                + " ' "
                + perApellido
                + " ' , "
                + "perNumTelefono = "
                + " ' "
                + perNumTelefono
                + " ' , "
                + "perCorreo = "
                + " ' "
                + perCorreo 
                + " ' "
                + "WHERE perCedula = "
                + perCedulaBus;
            return objDatos.ejecutarDML(consulta);
        }
        public int eliminarCliente(int cedula)
        {
            string consulta = $"DELETE FROM Cliente WHERE perCedula = {cedula}";
            return objDatos.ejecutarDML(consulta);
        }
    }
}
