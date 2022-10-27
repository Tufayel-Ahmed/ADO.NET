using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Single_Database_Transaction_using_ADO.NETT
{
    class Program
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before Transaction");
                GetAccountsData();
                TransferMoney();
                Console.WriteLine("After Transaction");
                GetAccountsData();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TransferMoney()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string queryAccount1 = "UPDATE Accounts SET Balance = Balance - 500 WHERE AccountNumber = 'Account1';";
                SqlCommand cmd = new SqlCommand(queryAccount1, connection, transaction);
                cmd.ExecuteNonQuery();

                string queryAccount2 = "UPDATE MyAccounts SET Balance = Balance + 500 WHERE AccountNumber = 'Account2';";
                cmd = new SqlCommand(queryAccount2, connection, transaction);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Transaction committed");
            }
            catch
            {
                transaction.Rollback();
                Console.WriteLine("Transaction rollback");
            }
        }

        private static void GetAccountsData()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM Accounts;";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Account Name\t\tCustomer Name\t\tBalance");
                while (reader.Read())
                {
                    Console.Write($"{reader["AccountNumber"]}\t\t");
                    Console.Write($"{reader["CustomerName"]}\t\t\t");
                    Console.Write($"{reader["Balance"]}\t\t");
                    Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}