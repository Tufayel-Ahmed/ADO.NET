using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Delete_data_using_DataTable_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDataTableMethod();
        }

        public static void UseDataTableMethod()
        {
            SqlConnection connection = null;

            try
            {
                string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                connection = new SqlConnection(conString);

                string query = "SELECT * FROM Student;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

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
                
                foreach(DataRow row in dataTable.Rows)
                {
                    if (Convert.ToInt32(row["Id"]) == 102)
                    {
                        row.Delete();
                        Console.WriteLine("101 Id record deleted.");
                    }
                }
                dataTable.AcceptChanges();

                Console.WriteLine("After deletion");
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