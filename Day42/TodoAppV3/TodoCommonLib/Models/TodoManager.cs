using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace TodoCommonLib.Models
{
    public class TodoManager
    {
        public static void AddTodoList(string desc, string prioritize)
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand($"Insert into TodoList (Description,Priority) values ('{desc}','{prioritize}')", con);

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

        public static void RemoveTodo(int removeNumber)
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand($"delete TodoList where ID = {removeNumber}", con);
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

        public static void UpdateTodo(int updateNumber, string updatePriority)
        {
            var conString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true; TrustServerCErtificate=true";
            var con = new SqlConnection(conString);
            var cmd = new SqlCommand($"Update TodoList set Priority = '{updatePriority}' where ID = {updateNumber}", con);
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
        public static void DisplayTodoList()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " TodoList", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader["ID"] + " --> ");
                Console.Write(reader["Description"] + " || ");
                Console.Write(reader["Priority"] + " || ");
                Console.WriteLine();

            }
            con.Close();

        }
    }
}
