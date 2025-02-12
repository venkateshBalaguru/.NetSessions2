using MySql.Data.MySqlClient;

namespace MySqlSimpleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");
                    Console.Write("Enter the name : ");
                    var name = Console.ReadLine();
                    Console.Write("Enter the Address : ");
                    var address = Console.ReadLine();
                    Console.Write("Enter the City : ");
                    var city = Console.ReadLine();
                    string query = "INSERT INTO employee (Name, Address, City) VALUES (@name, @address, @city)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", $"{name}");
                        cmd.Parameters.AddWithValue("@address", $"{address}");
                        cmd.Parameters.AddWithValue("@city", $"{city}");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            }
        }
        }
    }

