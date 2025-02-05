using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCommonLib.Models
{

    public class TodoManager
    {

        public static void AddTodoList(string desc, string prioritize)
        {
            var details = $"{desc},{prioritize}";
            FileStream fs = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day37\Todo.txt", FileMode.Append);
            //inserting the Data in to file
            StreamWriter sw = new StreamWriter(fs);  //this is old type
            sw.WriteLine(details);
            sw.Close();
            fs.Close();
        }

        public static void DisplayTodoList()
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day37\\Todo.txt";
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
