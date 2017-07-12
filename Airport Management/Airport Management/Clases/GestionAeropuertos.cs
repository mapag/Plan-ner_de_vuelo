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
            
          
            string consulta = "Select * from rutas where codigo_RTA = '" + codigo + "'";

            int cantidad = ad.ContarRegistros(consulta);
            if (cantidad > 0) return true;
            return false;
        }



    }
}
