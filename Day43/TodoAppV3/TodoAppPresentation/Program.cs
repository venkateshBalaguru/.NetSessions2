using TodoCommonLib.Models;
namespace TodoAppPresentation
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Todo App\n========");
            Console.WriteLine("1. Add Todo");
            Console.WriteLine("2. Display Todo");
            Console.WriteLine("3. Update Todo's By ID");
            Console.WriteLine("4. Remove Todo's by ID");
            Console.WriteLine("5. Exit");
            Console.Write("\nEnter the Number to Proceed : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                EnterDetails();
            }
            //else if (number == 2)
            //{
            //    Console.WriteLine(TodoManager.DisplayTodoList());
            //    ToContinue();
            //}
            //else if (number == 3)
            //{
            //    Console.Write("Enter the Id number to Update from the List : ");
            //    var updateNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the Priority to Update");
            //    var updatePriority = Console.ReadLine();
            //    Console.WriteLine(TodoManager.UpdateTodo(updateNumber, updatePriority));
            //    ToContinue();
            //}
            //else if (number == 4)
            //{
            //    Console.Write("Enter the Id number to remove from the List : ");
            //    var removeNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(TodoManager.RemoveTodo(removeNumber));
            //    ToContinue();
            //}
            else if (number == 5)
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
            var result = TodoManager.AddTodoList(desc, prioritize);
            Console.WriteLine(result);
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