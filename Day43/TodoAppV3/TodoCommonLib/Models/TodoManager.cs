using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Net;
using System.Xml.Linq;

namespace TodoCommonLib.Models
{
    public class TodoManager
    {
        public static string AddTodoList(string desc, string prioritize)
        {
            string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
            using (var con = new MySqlConnection(conString))
            {


                try
                {
                    con.Open();
                    Console.WriteLine("Connection successfully");
                    string query = "INSERT INTO TodoList (Description, Priority) VALUES (@desc, @priority)";
                    var cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@desc", $"{desc}");
                    cmd.Parameters.AddWithValue("@priority", $"{prioritize}");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return $"{rowsAffected} row(s) inserted";

                    //var cmd = new MySqlCommand($"Insert into TodoList (Description,Priority) values ('{desc}','{prioritize}')", con);
                    //int rowsAffected = cmd.ExecuteNonQuery();
                    //return $"{rowsAffected} row(s) inserted";
                }
                catch (Exception ex)
                {
                    return $"Error: " + ex.Message;
                }
            }
      
        }

        //public static string RemoveTodo(int removeNumber)
        //{
        //    string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
        //    var con = new SqlConnection(conString);
        //    var cmd = new SqlCommand($"delete TodoList where ID = {removeNumber}", con);
        //    try
        //    {
        //        con.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        return $"{rowsAffected} row(s) deleted";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Error: " + ex.Message;
        //    }
        //}

        //public static string UpdateTodo(int updateNumber, string updatePriority)
        //{
        //    string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
        //    var con = new SqlConnection(conString);
        //    var cmd = new SqlCommand($"Update TodoList set Priority = '{updatePriority}' where ID = {updateNumber}", con);
        //    try
        //    {
        //        con.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        return $"{rowsAffected} row(s) Updated.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Error: " + ex.Message;
        //    }
        //}
        //public static string DisplayTodoList()
        //{
        //    string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
        //    var con = new SqlConnection(conString);
        //    var cmd = new SqlCommand("select * from" +
        //        " TodoList", con);
        //    con.Open();
        //    var reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        return $"{reader["ID"]} --> \n{reader["Description"]} | \n{reader["Priority"]}\n";
        //    }
        //    con.Close();
        //    return "No Data's to display";
        //}
    }
}
