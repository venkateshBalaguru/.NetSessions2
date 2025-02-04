using TodoList_1.Models;
namespace TodoList_1
{

        internal class Program
        {
            static void Main()
            {
                Console.WriteLine("Todo App\n========");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display Todo");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter the Number to Proceed : ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("Enter the Description of the Todo :");
                    var desc = Console.ReadLine();
                    Console.WriteLine("Enter the Priority");
                    var prioritize = Console.ReadLine();
                    TodoManager.AddTodoList(desc, prioritize);
                    Console.WriteLine("Do You want to Continue Press \"Y\"");
                    var key = Console.ReadLine();
                    if (key == "y"  || key == "Y")
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Exit the App");
                    }
                }
                else if (number == 2)
                {
                    TodoManager.DisplayTodoList();
                }
                else { Console.WriteLine("Exit the App"); }
            }
        }
    }
