﻿using Microsoft.Data.SqlClient;

namespace ProductDatabaseConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " product", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
                Console.WriteLine(reader["quantity"]);
                Console.WriteLine(reader["price"]);

            }
            con.Close();
        }

        private static void CaseStudy1()
        {

            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            con.Open();
            Console.Write("Connection Opened and Connected to ==>");
            Console.WriteLine(con.Database);
            Console.Write("connection state is==>");
            Console.WriteLine(con.State);

            con.Close();
        }
    }
}
