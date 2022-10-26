using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Copy_and_clone_table_using_DataTable_Methods
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
                Console.WriteLine();

                Console.WriteLine("----------Copy Data Table----------");
                DataTable copyDataTable = dataTable.Copy();
                Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                if(copyDataTable != null)
                {
                    foreach (DataRow row in copyDataTable.Rows)
                    {
                        Console.Write($"{row["Id"]}\t\t");
                        Console.Write($"{row["Name"]}\t\t\t");
                        Console.Write($"{row["Email"]}\t\t");
                        Console.Write($"{row["Mobile"]}");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();

                Console.WriteLine("----------Clone Data Table----------");
                DataTable cloneDataTable = dataTable.Copy();
                Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                if(cloneDataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in cloneDataTable.Rows)
                    {
                        Console.Write($"{row["Id"]}\t\t");
                        Console.Write($"{row["Name"]}\t\t\t");
                        Console.Write($"{row["Email"]}\t\t");
                        Console.Write($"{row["Mobile"]}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Clone data table is empty.");
                    Console.WriteLine("Adding data to clone data table.");
                    cloneDataTable.Rows.Add(101, "Test1", "test1@gmail.com");
                    cloneDataTable.Rows.Add(102, "Test2", "test2@gmail.com");

                    Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                    foreach (DataRow row in cloneDataTable.Rows)
                    {
                        Console.Write($"{row["Id"]}\t\t");
                        Console.Write($"{row["Name"]}\t\t\t");
                        Console.Write($"{row["Email"]}\t\t");
                        Console.Write($"{row["Mobile"]}");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}