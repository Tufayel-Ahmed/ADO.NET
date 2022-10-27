using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Call_a_stored_procedure_with_an_input_and_output_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            CallStoreProcedure();
        }

        public static void CallStoreProcedure()
        {
            SqlConnection connection = null;

            try
            {
                string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                connection = new SqlConnection(conString);

                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "spCreateStudent",
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter parameter1 = new SqlParameter()
                {
                    ParameterName = "@Name",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = "Test",
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(parameter1);
                cmd.Parameters.AddWithValue("@Email", "test@gmail.com");
                cmd.Parameters.AddWithValue("Mobile", "123456789");

                SqlParameter outParameter = new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParameter);

                connection.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine($"Newely Generated Student ID: {outParameter.Value.ToString()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}