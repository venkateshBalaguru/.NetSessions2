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
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    todoManager.AddTodo();
                    var file = todoManager.GetTodos();
                    var jsonString = JsonSerializer.Serialize(file);
                    Console.WriteLine(jsonString);
                    var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\Todo_2\Cus1.json");
                    sw.WriteLine(jsonString);
                    sw.Close();
                    Console.WriteLine("Written to File...");
                }
                else if (choice == "2")
                {
                    var sr = new StreamReader(@"C:\venkat-html-app\DotNetSessions\Day38\Todo_2\Cus1.json");
                    var jsonString = sr.ReadToEnd();
                    //Console.WriteLine(jsonString);
                    //Deserialization will create a new object without using new keyword it will happen in background but the fields must be public otherwise it will throw error
                    var todos = JsonSerializer.Deserialize<Todo>(jsonString);
                    Console.WriteLine("After Deserialized :");
                    Console.WriteLine($"Discription : {todos.Description} | Priority : {todos.Priority}");
                    
                    DisplayTodos(todos);

                }
                else if (choice == "3")
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

        static void DisplayTodos(Todo todos)
        {
            Console.WriteLine("Todos:");

                Console.WriteLine(todos.ToString());

        }
    }

}
