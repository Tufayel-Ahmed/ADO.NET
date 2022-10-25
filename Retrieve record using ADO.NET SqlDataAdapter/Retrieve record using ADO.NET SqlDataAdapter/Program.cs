using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Retrieve_record_using_ADO.NET_SqlDataAdapte
{
    class Program
    {
        static void Main(string[] args)
        {
            RetrieveRecord();
        }

        public static void RetrieveRecord()
        {

            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(ConString);

                string query = "SELECT * FROM Student";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                Console.WriteLine("---------- Using Data Table ----------");
                Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.Write($"{row["Id"]}\t\t");
                    Console.Write($"{row["Name"]}\t\t\t");
                    Console.Write($"{row["Email"]}\t\t");
                    Console.Write($"{row["Mobile"]}");
                    Console.WriteLine();
                }

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Student");

                Console.WriteLine("---------- Using Data Set ----------");
                Console.WriteLine("ID\t\tName\t\t\t\tEmail\t\t\t\tMobile No");
                foreach (DataRow row in dataSet.Tables["Student"].Rows)
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