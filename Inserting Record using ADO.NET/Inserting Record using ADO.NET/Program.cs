using System;
using Microsoft.Data.SqlClient;

namespace Inserting_Record_using_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
        }

        public static void InsertData()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection("Server = DESKTOP-VDA92FM\\SQLEXPRESS; Database = University; Trusted_Connection = true; Encrypt =false;");
                string query = "INSERT INTO Student VALUES(171442005, 'Md Abul Kalam Azad', 'azad@gmail.com', '2020-10-05')";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Data inserted successfully.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Data can not insert.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}