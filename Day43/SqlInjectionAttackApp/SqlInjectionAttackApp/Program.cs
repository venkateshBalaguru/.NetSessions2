﻿using Microsoft.Data.SqlClient;

namespace SqlInjectionAttackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();//Sql injection it will affect
            //CaseStudy2();//Solution for sql injection
           
        }

        private static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);

            Console.WriteLine("Enter a product id :");
            var productId = Console.ReadLine();

            var cmd = new SqlCommand("select * from product where id = @paramProductId", con);//step1 create a parameter
            cmd.Parameters.AddWithValue("@paramProductId", productId);//step 2;
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Console.WriteLine(reader["name"]);
            }
            con.Close();
        }

        public static void CaseStudy1()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);


            Console.WriteLine("Enter a product id : ");
            var productId = Console.ReadLine();


            var cmd = new SqlCommand($"select * from product where id = {productId}", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
            }
            con.Close();
        }
    }
}
