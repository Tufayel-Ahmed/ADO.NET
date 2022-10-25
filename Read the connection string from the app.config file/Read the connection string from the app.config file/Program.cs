using System;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace Read_the_connection_string_from_the_app.config_file
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    connection.Open();
                    Console.WriteLine("Connection Established Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

    }
}