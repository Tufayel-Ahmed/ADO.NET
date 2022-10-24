using System;
using Microsoft.Data.SqlClient;

namespace Deleting_Record_from_SQL_Server_database_using_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteData();
        }

        public static void DeleteData()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection("Server = DESKTOP-VDA92FM\\SQLEXPRESS; Database = University; Trusted_Connection = True; Encrypt = false;");
                string query = "DELETE FROM Student WHERE ID = 171442005;";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Data deleted successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}