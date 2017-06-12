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
            ad.cargaTabla(nombreTabla, "select * from Aviones", ref ds);
        }

        public void ObtenerTodosLosProductosClausula(String clausula, String nombreTabla, ref DataSet ds)
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
                ArmarParametrosProductosEliminar(ref Comando, fila);
                FilasEliminadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarProducto");
            }
            if (FilasEliminadas >= 1)
                return true;
            else
                return false;
        }


        private void ArmarParametrosProductosEliminar(ref SqlCommand Comando, DataRow fila)
        {
            /*
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = fila["IdProducto"];
            */
        }



        public bool modificarAvion(String NombreTabla, DataSet ds)
        {
            int FilasActualizadas = 0;
            foreach (DataRow fila in ds.Tables[NombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                ArmarParametrosAviones(ref Comando, fila);
                AccesoDatos ad = new AccesoDatos();

                FilasActualizadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarProducto");
            }
            if (FilasActualizadas >= 1)
                return true;
            else
                return false;
        }

        public void ArmarParametrosAviones(ref SqlCommand Comando, DataRow fila)
        {
            /*
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = fila["IdProducto"];
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            SqlParametros.Value = fila["NombreProducto"];
            SqlParametros = Comando.Parameters.Add("@IdProveedor", SqlDbType.Int);
            SqlParametros.Value = fila["IdProveedor"];
            SqlParametros = Comando.Parameters.Add("@IdCategoria", SqlDbType.Int);
            SqlParametros.Value = fila["IdCategoría"];
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            SqlParametros.Value = fila["CantidadPorUnidad"];
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = fila["PrecioUnidad"];
            SqlParametros = Comando.Parameters.Add("@UnidadesEnExistencia", SqlDbType.SmallInt);
            SqlParametros.Value = fila["UnidadesEnExistencia"];
            SqlParametros = Comando.Parameters.Add("@UnidadesEnPedido", SqlDbType.SmallInt);
            SqlParametros.Value = fila["UnidadesEnPedido"];
            SqlParametros = Comando.Parameters.Add("@NivelNuevoPedido", SqlDbType.SmallInt);
            SqlParametros.Value = fila["NivelNuevoPedido"];
            SqlParametros = Comando.Parameters.Add("@Suspendido", SqlDbType.Bit);
            if (fila["Suspendido"].ToString().Trim() == "")
                SqlParametros.Value = false;
            else
                SqlParametros.Value = fila["Suspendido"];
            */
        }

        public Boolean InsertarAvion(String NombreTabla, DataSet ds)
        {
            /*
            int FilasInsertadas=0;
            foreach (DataRow fila in ds.Tables[NombreTabla].Rows)
            {
                SqlCommand Comando = new SqlCommand();
                ArmarParametrosAviones(ref Comando, fila);
                AccesoDatos ad = new AccesoDatos();
                FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarProducto");
            }
            if (FilasInsertadas >= 1)
                return true;
            else
                return false;
             */
            return true;
        }





    }
}
