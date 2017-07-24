using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Airport_Management.Clases
{
    class GestionVuelos
    {
        //GESTION CATEGORÍA TRABAJA CON LA CLASE CATEGORÍAS.

        public GestionVuelos()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public bool VueloExiste(string codigo)
        {
            AccesoDatos ac = new AccesoDatos();
            string consulta = "select codigo_VLO from vuelos where codigo_VLO = '" + codigo + "'" ;
            int cantidad = ac.ContarRegistros(consulta);
            if (cantidad == 0) return false;
            else return true;
        }

        public DataSet TraerVueloCodigo(string codigo)
        {
            DataSet ds = new DataSet();
            AccesoDatos ad = new AccesoDatos();
            string consulta = "Select * from vuelos where codigo_VLO = '" + codigo + "'";

            ad.cargaTabla("Vuelos", consulta, ref ds);
            return ds;
        }

    }
}
