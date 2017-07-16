using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Airport_Management
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
    }
}
