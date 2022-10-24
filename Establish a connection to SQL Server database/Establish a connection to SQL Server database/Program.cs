using System;
using Microsoft.Data.SqlClient;

namespace Establish_a_connection_to_SQL_Server_database
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectToServer();
        }

        public static void ConnectToServer()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("Server = DESKTOP-VDA92FM\\SQLEXPRESS; Database = University; Trusted_Connection = True; Encrypt = false;");
                connection.Open();
                Console.WriteLine("Connection established successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Connection do not establish. Because of");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

    }
}