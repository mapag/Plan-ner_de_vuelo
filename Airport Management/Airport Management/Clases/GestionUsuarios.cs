using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Airport_Management.Clases
{
    class GestionUsuarios
    {
        SqlConnection connection;
        SqlCommand command;

        public GestionUsuarios()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Airport_Manager;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor
        public bool GetUsersData(ref string lastname, ref string firstname, ref string age)
        {
            bool returnvalue = false;
            try
            {
                command.CommandText = "select * from TableName where firstname=@firstname and lastname=@lastname";
                command.Parameters.Add("firstname", SqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("lastname", SqlDbType.VarChar).Value = lastname;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        lastname = reader.GetString(1);
                        firstname = reader.GetString(2);

                        age = reader.GetString(3);


                    }
                }
                returnvalue = true;
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return returnvalue;
        }

        public bool usuarioExiste(string usuario)
        {
            AccesoDatos ac = new AccesoDatos();
            string consulta = "select usuario_USU from usuarios where usuario_USU = '" + usuario + "'";
            int cantidad = ac.ContarRegistros(consulta);
            if (cantidad == 0) return false;
            else return true;
        }

        public void crearUsuario (string usuario, string contrasena, string nombre, string apellido, string correo, string telefono)
        {
            string consultaSQL = "INSERT INTO usuarios(usuario_USU, contrasena_USU, nombre_USU, apellido_USU) SELECT '" + usuario + "', '" + contrasena + "', '" + nombre + "', '" + apellido + "'";

            if (correo != "" && telefono == "")
                consultaSQL = "INSERT INTO usuarios(usuario_USU, contrasena_USU, nombre_USU, apellido_USU, correo_USU) SELECT '" + usuario + "', '" + contrasena + "', '" + nombre + "', '" + apellido + "', '" + correo + "'";

            if (correo == "" && telefono != "")
                consultaSQL = "INSERT INTO usuarios(usuario_USU, contrasena_USU, nombre_USU, apellido_USU, telefono_USU) SELECT '" + usuario + "', '" + contrasena + "', '" + nombre + "', '" + apellido + "', '" + telefono + "'";


            if (telefono != "" && correo != "")
                consultaSQL = consultaSQL = "INSERT INTO usuarios(usuario_USU, contrasena_USU, nombre_USU, apellido_USU, correo_USU, telefono_USU) SELECT '" + usuario + "', '" + contrasena + "', '" + nombre + "', '" + apellido + "', '" + correo + "', '" + telefono + "'";

            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarConsulta(consultaSQL);
        }
    }
}
