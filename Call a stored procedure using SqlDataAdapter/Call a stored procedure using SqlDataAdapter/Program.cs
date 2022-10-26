using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Call_a_stored_procedure_using_SqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CallStoredProcedure();
        }

        public static void CallStoredProcedure()
        {
            SqlConnection connection = null;

            try
            {
                string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                connection = new SqlConnection(conString);

                string query = "spGetStudents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.Write($"{row["Id"]}\t\t");
                    Console.Write($"{row["Name"]}\t\t\t");
                    Console.Write($"{row["Email"]}\t\t");
                    Console.Write($"{row["Mobile"]}");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}