using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ADO.NET_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDataTable();
        }

        public static void CreateDataTable()
        {
            try
            {
                DataTable dataTable = new DataTable("Student");
                
                DataColumn Id = new DataColumn();
                Id.ColumnName = "ID";
                Id.DataType = typeof(int);
                Id.AutoIncrement = true;
                Id.AutoIncrementSeed = 1000;
                Id.AutoIncrementStep = 1000;
                Id.Unique = true;
                Id.AllowDBNull = false;
                Id.Caption = "Student ID";
                dataTable.Columns.Add(Id);
                dataTable.PrimaryKey = new DataColumn[] { Id };

                DataColumn Name = new DataColumn()
                {
                    ColumnName = "Name",
                    DataType = typeof(string),
                    AllowDBNull = false
                };
                dataTable.Columns.Add(Name);

                DataColumn Email = new DataColumn("Email");
                dataTable.Columns.Add(Email);

                dataTable.Rows.Add(null, "Selim", "selim@gmail.com");

                DataRow row1 = dataTable.NewRow();
                row1["Name"] = "Tufayel Ahmed";
                row1["Email"] = "ahmed@gmail.com";
                dataTable.Rows.Add(row1);

                Console.WriteLine("ID\t\tName\t\t\t\tEmail");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.Write($"{row["Id"]}\t\t");
                    Console.Write($"{row["Name"]}\t\t\t\t");
                    Console.Write($"{row["Email"]}\t\t");
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