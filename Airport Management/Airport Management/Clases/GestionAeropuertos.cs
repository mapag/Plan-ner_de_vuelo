using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airport_Management.Clases
{
    class GestionAeropuertos
    {
        public GestionAeropuertos()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public bool CodigoExiste(string codigo)
        {
            AccesoDatos ad = new AccesoDatos();
            
          
            string consulta = "Select * from aeropuertos where codigo_ATO = '" + codigo + "'";

            int cantidad = ad.ContarRegistros(consulta);
            if (cantidad > 0) return true;
            return false;
        }

        public void agregarAeropuerto(string codigo, string nombre, string pais, string provincia)
        {
            string consulta = "INSERT INTO aeropuertos (codigo_ATO, nombre_ATO, pais_ATO, provincia_ATO, contador_ATO) select '" +
                codigo + "', '" + nombre + "', '" + pais + "', '" + provincia + "', 0";
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarConsulta(consulta);

        }

        public void eliminarAeropuerto (string codigo)
        {
            AccesoDatos ad = new AccesoDatos();
            string consultaSQL = "DELETE FROM aeropuertos WHERE codigo_ATO = '" + codigo + "'";
            ad.EjecutarConsulta(consultaSQL);
            MessageBox.Show("El aeropuerto fue eliminado con éxito");
        }

    }
}
