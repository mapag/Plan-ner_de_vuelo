using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Airport_Management.Clases
{
    class GestionAviones
    {
        //GESTION CATEGORÍA TRABAJA CON LA CLASE CATEGORÍAS.

        public GestionAviones()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public void listarAviones(String nombreTabla, ref DataSet ds)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.cargaTabla(nombreTabla, "select a.codigo_AV as Código, b.fabricante_TA as Fabricante, b.modelo_TA as Modelo, b.descripcion_TA as Descripción from Aviones a inner join tipos_de_aviones b on b.codigo_TA = a.tipo_AV", ref ds);
        }

        public void listarAvionesClausula(String clausula, String nombreTabla, ref DataSet ds)
        {
            AccesoDatos ad = new AccesoDatos();
            ad.cargaTabla(nombreTabla, clausula, ref ds);
        }

        public bool eliminarAvion(String NombreTabla, DataSet ds)
        {
            int FilasEliminadas = 0;
            foreach (DataRow fila in ds.Tables[NombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                fila.RejectChanges();
                AccesoDatos ad = new AccesoDatos();
                ArmarParametrosAvionesEliminar(ref Comando, fila);
                FilasEliminadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarAvion");
            }
            if (FilasEliminadas >= 1)
                return true;
            else
                return false;
        }


        private void ArmarParametrosAvionesEliminar(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Codigo_AV", SqlDbType.VarChar);
            SqlParametros.Value = fila["codigo_av"];
            
        }



        public bool modificarAvion(String NombreTabla, DataSet ds)
        {
            int FilasActualizadas = 0;
            foreach (DataRow fila in ds.Tables[NombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                ArmarParametrosAviones(ref Comando, fila);
                AccesoDatos ad = new AccesoDatos();

                FilasActualizadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spModificarAvion");
            }
            if (FilasActualizadas >= 1)
                return true;
            else
                return false;
        }

        public void ArmarParametrosAviones(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@codigo_AV", SqlDbType.VarChar, 10);
            SqlParametros.Value = fila["codigo_av"];
            SqlParametros = Comando.Parameters.Add("@tipo_AV", SqlDbType.VarChar, 10);
            SqlParametros.Value = fila["tipo_av"];
        }

        public Boolean InsertarAvion(String NombreTabla, DataSet ds)
        {
            int FilasInsertadas=0;
            foreach (DataRow fila in ds.Tables[NombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                ArmarParametrosAviones(ref Comando, fila);
                AccesoDatos ad = new AccesoDatos();
                FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarAvion");
            }
            if (FilasInsertadas >= 1)
                return true;
            else
                return false;
        }





    }
}
