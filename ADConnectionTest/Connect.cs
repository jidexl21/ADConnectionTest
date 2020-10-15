using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADConnectionTest
{
    public class Connect
    {
        public static string connectionString { get; set; }


        public Connect()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string qry = "Select 1+1 result"; ;
                var cmd = connection.CreateCommand();
                cmd.CommandText = qry;
                DataTable dt = new DataTable();
                using ( SqlDataAdapter adapter = new SqlDataAdapter()) {
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                };
               
            }
            Console.WriteLine($"Successful  Connection: {connectionString}");

        }
    }

}
