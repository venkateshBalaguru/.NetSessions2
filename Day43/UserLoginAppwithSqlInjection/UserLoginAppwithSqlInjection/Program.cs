using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace UserLoginAppwithSqlInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }
        public static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                Console.Write("Enter the User Name : ");
                var userName = Console.ReadLine();
                Console.Write("Enter the Password : ");
                var userPwd = Console.ReadLine();

                var cmd = new SqlCommand($"select * from userlogin where username = {userName} and userpwd = {userPwd}", con);
                //cmd.Parameters.AddWithValue("@userName", userName);
                //cmd.Parameters.AddWithValue("@userPwd", userPwd);

                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\nRRD Home Page\n");
                    Console.WriteLine(reader["msg"]);
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
                while (reader.Read())
                {
                    Console.WriteLine("\nRRD Home Page\n");
                    Console.WriteLine(reader["msg"]);
                }
                con.Close();
            }
        }
    }
}
