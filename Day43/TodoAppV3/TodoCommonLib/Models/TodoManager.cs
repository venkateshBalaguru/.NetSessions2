using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Data;

namespace TodoCommonLib.Models
{
    public class TodoManager
    {
        public static string AddTodoList(string desc, string prioritize)
        {
            string conString = "Server=127.0.0.1;Database=rrd_mysqldb;User ID=root;Password=root;Pooling=true;";
            using (var con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO TodoList (Description, Priority) VALUES (@desc, @priority)";
                    var cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@desc", $"'{desc}'");
                    cmd.Parameters.AddWithValue("@priority", $"'{prioritize}'");
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return $"{rowsAffected} row(s) inserted.";
                }
                catch (Exception ex)
                {
                    return $"Error: " + ex.Message;
                }
            }

        }
        public static string RemoveTodo(int removeNumber)
        {
            string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
            var con = new MySqlConnection(conString);
            var cmd = new MySqlCommand($"delete from TodoList where Id = {removeNumber}", con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return $"{rowsAffected} row(s) deleted";
            }
            catch (Exception ex)
            {
                return $"Error: " + ex.Message;
            }
        }

        public static string UpdateTodo(int updateNumber, string updatePriority)
        {
            string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
            var con = new MySqlConnection(conString);
            var cmd = new MySqlCommand($"Update TodoList set Priority = '{updatePriority}' where ID = {updateNumber}", con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return $"{rowsAffected} row(s) Updated.";
            }
            catch (Exception ex)
            {
                return $"Error: " + ex.Message;
            }
        }
        public static List<(int,string,string)> DisplayTodoList()
        {
            var todo = new List<(int,string,string)>();
            string conString = "Server=127.0.0.1;Database=rrd_MySqlDB;User ID=root;Password=root;Pooling=true;";
            var con = new MySqlConnection(conString);
            var cmd = new MySqlCommand("select Id,Description,Priority from" + " TodoList", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string desc = reader.GetString(1);
                string priority = reader.GetString(2);
                todo.Add((id,desc,priority)); 
            }
            con.Close();
            return todo;
        }
    }
}




