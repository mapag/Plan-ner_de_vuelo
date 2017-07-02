using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airport_Management.Clases
{
    class AccesoDatos
    {
        String rutaBD =
    "Data Source=localhost\\sqlexpress;Initial Catalog=Airport_Manager;Integrated Security=True";

        public AccesoDatos()
        {
            // TODO: Agregar aquí la lógica del constructor
        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBD);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void cargaTabla(String NombreTabla, String Sql, ref DataSet ds)
        {
            SqlConnection cn = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, cn);
            adp.Fill(ds, NombreTabla);
            cn.Close();
        }

        public void EjecutarConsulta(string consulta) 
        {
            SqlConnection cn = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public int ContarRegistros(string consultaSQL)
        {
            int cantidad=0;
            SqlConnection cn = ObtenerConexion();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = consultaSQL;
            comando.Connection = cn;
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                cantidad++; ;
            }
            cn.Close();
            return cantidad;
        }


        public void EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            Conexion.Close();
        }

        public void AgregaraComboBox(string consulta, ref ComboBox cmb)
        {
            SqlConnection cn = ObtenerConexion();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = consulta;
            comando.Connection = cn;
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                cmb.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        public void AgregaraListBox(string consulta, ref ComboBox lst)
        {
            SqlConnection cn = ObtenerConexion();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = consulta;
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                lst.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }


        public void IniciarTabla(string consulta, string nombretabla, ref DataSet DS, ref DataGridView grid)
        {
            DS.Tables.Clear();
            SqlConnection cn = new SqlConnection(rutaBD);
            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn); ///adaptador cambia el string a consulta sql
            cn.Close();
            adaptador.Fill(DS, nombretabla);   //ACA CREA UNA TABLA EN EL DS CON UN NOMBRE ESPECIFICO, NO CONTROLA EL INDICE.
            grid.DataSource = DS.Tables[nombretabla]; ///ACA MUESTRA LA CONSULTA EN LA GRILLA
        }


    }
}
