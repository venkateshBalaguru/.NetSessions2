using System;
class PrintName
{
    static void Main()
    {
        //Print the name repeatedly using for loop by passing the arguments
        PrintNameFunction("Venkatesh", 10);

        //Print the name by user input using for loop
        PrintNameUserInput();
    }
    static void PrintNameFunction(string name, int iteration)//Passing the arguments
    {
        for (int i = 1; i <= iteration; i++)
        {
            Console.WriteLine($"Hi I am {name.ToUpper()} ! welcome {i}" );
        }
    }

    static void PrintNameUserInput() //user input
    {
        Console.Write("Enter your name:");
        string userName = Console.ReadLine();
        Console.Write("Enter the number of times to print your name: ");
        int iteration = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= iteration; i++)
        {
            Console.WriteLine($"Hi I am {userName} ! welcome {i}");
        }
    }
}
