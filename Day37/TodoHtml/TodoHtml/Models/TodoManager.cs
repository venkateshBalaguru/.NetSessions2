using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoHtml.Models
{
    public class TodoManager
    {
        //private List<Todo> _todo = new List<Todo>();


        public static void AddTodoList(string desc, string prioritize)
        {
            var details = $"{desc},{prioritize}";
            FileStream fs = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day37\Todo.txt", FileMode.Append);


            StreamWriter sw = new StreamWriter(fs);  //this is old type
            sw.WriteLine(details);
            sw.Close();
            fs.Close();

        }

        public static void DisplayTodoList()
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day37\\Todo.txt";
            List<Todo> todolist = new List<Todo>();  //using HashSet for getting the unique values


            //Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                //bool isFirstLine = true;  //For Ignoring the first line
                //Iterating until null
                while ((line = sr.ReadLine()) != null)
                {
                    //First line caption was removing and inserting the remaining lines
                    string[] values = line.Split(',');
                    for (int i = 0; i < 1; i++)
                    {
                        //empData.Add(new Employee(empId, values[i + 1], values[i + 2]));
                        todolist.Add(new Todo(values[i], values[i + 1]));
                    }
                }
                sr.Close();
            }
            Console.WriteLine("Details of the TodoList\n==========================");
            foreach (var value in todolist)
            {
                Console.WriteLine(value);
            }


        }
    }
}
