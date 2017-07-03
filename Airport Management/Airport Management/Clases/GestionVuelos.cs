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

        public void listarVuelos(String nombreTabla, ref DataSet ds)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.cargaTabla(nombreTabla, "select codigo_VLO as Código, codigo_RTA as Ruta, fecha_salida_VLO as [Fecha de salida] from vuelos", ref ds);
        }

        public bool VueloExiste(string codigo)
        {
            AccesoDatos ac = new AccesoDatos();
            string consulta = "select codigo_VLO from vuelos where codigo_VLO = '" + codigo + "'" ;
            int cantidad = ac.ContarRegistros(consulta);
            if (cantidad == 0) return false;
            else return true;
        }

    }
}
