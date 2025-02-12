using System.Data.SqlTypes;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace CRUDOnProductTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TableCreation();
            //Insertion();
            //Updation();
            //Deletion();
            View();




        }
        public static void TableCreation()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            //SQL command to create a table
            string createTableQuery = @"CREATE TABLE Product1(
                                        ID INT PRIMARY KEY IDENTITY(100,1),
                                        NAME VARCHAR(100),
                                        QUANTITY INT,
                                        PRICE MONEY)";

            var cmd = new SqlCommand(createTableQuery, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully.");
                con.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("The table not created " + ex.Message); 
            }
        }
        public static void Updation()
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand("Update Product1 set Quantity = 200 where ID = 101", con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) Updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void Deletion()
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand("delete Product1 where ID = 103", con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) Deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void Insertion()
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand("Insert into Product1 (NAME,QUANTITY,PRICE) values ('TABLET-N',10,5000)", con);
            
            try
            {
              con.Open();
              int rowsAffected = cmd.ExecuteNonQuery();
              Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        public static void View()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " Product1", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader["ID"]+" --> ");
                Console.Write(reader["NAME"]+" || ");
                Console.Write(reader["QUANTITY"]+ " || ");
                Console.Write(reader["PRICE"]);
                Console.WriteLine();

            }
            con.Close();
        }
    }
}
