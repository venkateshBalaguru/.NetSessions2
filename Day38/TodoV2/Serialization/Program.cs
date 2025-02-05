using TodoCommonLib.Models;

namespace Serialization
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
                EnterDetails();
            }
            else if (number == 2)
            {
                TodoManager.DisplayTodoList();
                ToContinue();
            }
            else if (number == 3)
            {
                Console.WriteLine("Exit the App");
            }
            else
            {
                Console.WriteLine("Enter the Correct Option");
                ToContinue();
            }
        }

        public static void EnterDetails()
        {
            Console.WriteLine("Enter the Description of the Todo :");
            var desc = Console.ReadLine();
            Console.WriteLine("Enter the Priority");
            var prioritize = Console.ReadLine();
            TodoManager.AddTodoList(desc, prioritize);
            ToContinue();
        }
        public static void ToContinue()
        {
            Console.WriteLine("Do You want to Continue Press \"Y\"");
            var key = Console.ReadLine();
            if (key == "y" || key == "Y")
                Main();
            else
                Console.WriteLine("Exit the App");
        }
    }
}