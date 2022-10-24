using System;
using Microsoft.Data.SqlClient;

namespace Create_a_table_using_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
        }

        public static void CreateTable()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("Server = DESKTOP-VDA92FM\\SQLEXPRESS; Database = University; Trusted_Connection = True; Encrypt = false;");
                string query = "CREATE TABLE Student(ID INT NOT NULL, Name VARCHAR(100), Email VARCHAR(50), [Join Date] date);";
                
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                
                Console.WriteLine("Create table successfully");
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