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
    class GestionAviones
    {
        //GESTION CATEGORÍA TRABAJA CON LA CLASE CATEGORÍAS.
        
        public GestionAviones()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private void ArmarParametrosAvionesAgregar(ref SqlCommand Comando, String codigo, String fabricante, String modelo)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@codigo", SqlDbType.VarChar, 10);
            SqlParametros.Value = codigo;
            SqlParametros = Comando.Parameters.Add("@fabricante", SqlDbType.VarChar, 50);
            SqlParametros.Value = fabricante;
            SqlParametros = Comando.Parameters.Add("@modelo", SqlDbType.VarChar, 50);
            SqlParametros.Value = modelo;

        }
        public bool AgregarAvion(string codigo, string fabricante, string modelo) { // Hacer un trigger para esta mierda XD

            AccesoDatos ad = new AccesoDatos();

           /* SIN PROCEDIMIENTO ALMACENADO, FUNCIONA
            string consultaSQL = "UPDATE aeropuertos SET contador_ATO=(SELECT contador_ATO FROM aeropuertos WHERE codigo_ATO='EZE')+1 WHERE codigo_ATO='EZE' INSERT INTO aviones(codigo_AV, tipo_AV, ultimo_ATO_programado_AV, ultima_fecha_programada_AV, posicion_AV, baja_AV) SELECT '"
                + codigo + "', (select codigo_TA from tipos_de_aviones where fabricante_TA = '" + fabricante + "' and modelo_TA = '" + modelo + "'), 'EZE' , GETDATE(), (SELECT contador_ATO FROM aeropuertos WHERE codigo_ATO='EZE'), 1";

           ad.EjecutarConsulta(consultaSQL);
            return true;*/

            //NO FUNCIONA, SQL SI FUNCIONA
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosAvionesAgregar(ref Comando, codigo, fabricante, modelo);
            ad.EjecutarProcedimientoAlmacenado(Comando, "agregarAvion");

            return true;
        }

        public bool CodigoExiste(string codigo) 
        {
            AccesoDatos ad = new AccesoDatos();
            string consulta = "Select * from aviones where codigo_AV = '" + codigo + "'";

            int cantidad = ad.ContarRegistros(consulta);
            if (cantidad>0) return true;
            return false;
        }

        public DataSet TraerAvionCodigo(string codigo)
        {
            DataSet ds = new DataSet();
            AccesoDatos ad = new AccesoDatos();
            string consulta = "Select * from aviones where codigo_AV = '" + codigo + "'";

            ad.cargaTabla("Aviones", consulta, ref ds);
            return ds;
        }

        public bool eliminarAvion(string codigo, string estado)
        {
            string consultaSQL = "";
            AccesoDatos ad = new AccesoDatos();
            if (estado == "1")
            {
                consultaSQL = "UPDATE aviones SET baja_AV = 0 WHERE codigo_AV = '" + codigo + "'";
            }
            else if (estado == "0")
            {
                consultaSQL = "UPDATE aviones SET baja_AV = 1 WHERE codigo_AV = '" + codigo + "'";
            }
            ad.EjecutarConsulta(consultaSQL);
            return true;

        }


        private void ArmarParametrosAvionesEliminar(ref SqlCommand Comando, DataRow fila)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Codigo", SqlDbType.VarChar);
            SqlParametros.Value = fila["Codigo"];
            
        }



      /*  public bool modificarAvion(String NombreTabla, DataSet ds)
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
        */

    }
}
