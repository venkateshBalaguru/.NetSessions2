using Microsoft.Data.SqlClient;

namespace UserLoginAppwithSqlInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }
        public static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                Console.Write("Enter the User Id : ");
                var userId = Console.ReadLine();
                Console.Write("Enter the Password : ");
                var userPwd = Console.ReadLine();

                //var cmd = new SqlCommand("select * from userlogin where id = " + userId + " and userpwd  = '" + userPwd + "'", con);
                //var cmd = new SqlCommand("SELECT * FROM USERLOGIN WHERE ID = " + userId + " AND USERPWD = '" + userPwd + "'", con);
                var cmd = new SqlCommand($"Select * from userlogin where id = {userId} and userpwd = {userPwd}", con);
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine("\nLogged Successfully\n");
                    Console.WriteLine(reader["msg"]);
                }
                else
                {
                    Console.WriteLine("Login failed");
                }
                con.Close();
            }
        }
        public static void CaseStudy1()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                Console.Write("Enter the User Name : ");
                var userName = Console.ReadLine();
                Console.Write("Enter the Password : ");
                var userPwd = Console.ReadLine();

                var cmd = new SqlCommand("SELECT * FROM userlogin WHERE username = @userName AND userpwd = @userPwd", con);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPwd", userPwd);

                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine("\nLogged Successfully\n");
                    Console.WriteLine(reader["msg"]);
                }
                else
                {
                    Console.WriteLine("Login failed");
                }
                con.Close();
            }
        }
    }
}
