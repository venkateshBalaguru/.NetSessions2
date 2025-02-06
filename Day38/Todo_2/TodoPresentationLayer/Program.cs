using System.Text.Json;
using TodoCommonLib.Models;

namespace TodoPresentationLayer
{
    public class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display Todos");
                Console.WriteLine("3. SerializeToJson");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    todoManager.AddTodo();
                    Console.WriteLine("Todo added sucessfully..");
                    
                }
                else if (choice == "2")
                {
                    DisplayTodos(todoManager.GetTodos());
                }
                else if (choice == "3")
                {
                    var file = todoManager.GetTodos();
                    var jsonString = JsonSerializer.Serialize(file);
                    Console.WriteLine(jsonString);
                    var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\Todo_2\Cus1.json");
                    sw.WriteLine(jsonString);
                    sw.Close();
                    Console.WriteLine("Written to File...");
                }
                else if (choice == "4")
                {
                    exit = true;
                }

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.WriteLine("Invalid choice, please try again.\n");
                }
            }

            Console.WriteLine("Thank you for using the Todo app.");
        }

        static void DisplayTodos(List<Todo> todos)
        {
            Console.WriteLine("Todos:");

                Console.WriteLine(todos.ToString());

        }
    }

}
