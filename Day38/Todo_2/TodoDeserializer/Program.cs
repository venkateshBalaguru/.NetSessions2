    using System.Text.Json;
    using TodoCommonLib.Models;

    namespace TodoDeserializer
    {
        public class Program
        {
            static void Main()
            {
            var sr = new StreamReader(@"C:\venkat-html-app\DotNetSessions\Day38\Todo_2\Cus1.json");
            var jsonString = sr.ReadToEnd();
            Console.WriteLine(jsonString);
            //Deserialization will create a new object without using new keyword it will happen in background but the fields must be public otherwise it will throw error
            var todo = JsonSerializer.Deserialize<Todo>(jsonString);
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

                    }
                    else if (choice == "2")
                    {
                        DisplayTodos(todoManager.GetTodos());
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

            static void DisplayTodos(List<Todo> todos)
            {
                Console.WriteLine("Todos:");

                Console.WriteLine(todos.ToString());

            }
        }

    }

