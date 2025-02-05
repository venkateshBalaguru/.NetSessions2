using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoCommonLib.Models
{
    public class TodoManager
    {
        //var jsonString = JsonSerializer.Serialize(c1);
        //Console.WriteLine(jsonString);
        //var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\Serialization_DeSerialization\Cus1.json");
        //sw.WriteLine(jsonString);
        //sw.Close();
            //Console.WriteLine("Written to File...");
        public static void AddTodoList(string desc, string prioritize)
        {
            var details = $"{desc},{prioritize}";
            var jsonString = JsonSerializer.Serialize(details);
            FileStream fs = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day38\TodoV2\Todo.json", FileMode.Append);
            //Writing the Data in to file
            StreamWriter sw = new StreamWriter(fs);  //this is old type
           sw.WriteLine(jsonString);
            Console.WriteLine(jsonString);
           
            sw.Close();
            fs.Close();
            Console.WriteLine("Written to file");
        }
        public static void DisplayTodoList()
        {
            string filePath = "@\"C:\\venkat-html-app\\DotNetSessions\\Day38\\TodoV2\\Todo.json\"";
            List<Todo> todolist = new List<Todo>();

            //Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    for (int i = 0; i < 1; i++)
                    {
                        todolist.Add(new Todo(values[i], values[i + 1]));
                    }
                }
                sr.Close();
            }
            Console.WriteLine("\nDetails of the TodoList\n==========================");
            foreach (var value in todolist)
            {
                Console.WriteLine(value);
            }


        }
    }
}
