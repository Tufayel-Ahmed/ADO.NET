using System;
using System.Data;

namespace ADO.NET_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDataSet();
        }

        public static void CreateDataSet()
        {
            try
            {
               DataTable dataTable = new DataTable("Customer");

                DataColumn customerID = new DataColumn("Customer ID", typeof(Int32));
                dataTable.Columns.Add(customerID);

                DataColumn customerName = new DataColumn("Customer Name", typeof(string));
                dataTable.Columns.Add(customerName);

                DataColumn customerMobileNo = new DataColumn("Customer Mobile No", typeof(string));
                dataTable.Columns.Add(customerMobileNo);

                dataTable.Rows.Add(101, "Tufayel Ahmed", "123");
                dataTable.Rows.Add(102, "Selim Reza", "456");

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);

                Console.WriteLine("ID\t\tName\t\t\t\t\tMobile");
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.Write($"{row["Customer ID"]}\t\t");
                    Console.Write($"{row["Customer Name"]}\t\t\t\t");
                    Console.Write($"{row["Customer Mobile No"]}\t\t");
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