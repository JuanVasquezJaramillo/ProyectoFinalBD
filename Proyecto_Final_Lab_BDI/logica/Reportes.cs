using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Lab_BDI.accesoDatos;
using System.Data;


namespace Proyecto_Final_Lab_BDI.logica
{
    class Reportes
    {
        Datos objDatos = new Datos();
        public DataSet primerReporte()
        {
            DataSet localDataSet = new DataSet();
            string consulta = $"select destNombre from Paquete inner join Destino on Paquete.destCodigo = Destino.destCodigo where paqCosto < {350000}";
            localDataSet = objDatos.ejecutarSelect(consulta);
            return localDataSet;
        }

        public DataSet segundoReporte()
        {
            DataSet localDataSet = new DataSet();
            
            string consulta = "SELECT * FROM Cliente";
            localDataSet = objDatos.ejecutarSelect(consulta);
            return localDataSet;
        }

        public DataSet tercerReporte()
        {
            DataSet localDataSet = new DataSet();

            string consulta = "SELECT * FROM Empleado";
            localDataSet = objDatos.ejecutarSelect(consulta);
            return localDataSet;
        }

    }
}
