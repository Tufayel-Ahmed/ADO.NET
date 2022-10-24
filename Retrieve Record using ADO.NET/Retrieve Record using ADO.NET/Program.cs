using System;
using Microsoft.Data.SqlClient;

namespace Retrieve_Record_using_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            RetrieveData();
        }

        public static void RetrieveData()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection("Server = DESKTOP-VDA92FM\\SQLEXPRESS; Database = University; Trusted_Connection = True; Encrypt = false;");
                string query = "SELECT * FROM Student";

                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Data retrieved successfully");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["ID"]}");
                    Console.WriteLine($"Name: {reader["Name"]}");
                    Console.WriteLine($"Email: {reader["Email"]}");
                    Console.WriteLine($"Join Date: {reader["Join Date"]}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

    }
}