using System;

class HelloReverse
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments Passed, Pls pass the arguments");
            return;
        }
        Console.WriteLine("The Names are in Straight Order");
        for (int i = 0; i < userNames.Length; i++) //Straight order printing the names
        {

            Console.WriteLine("Hi Welcome: " + userNames[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The Names are in Reverse Order");
        for (int i = userNames.Length - 1; i >= 0; i--)//printing in Reverse order
        {

            Console.WriteLine("Hi RRD Folks!==>" + userNames[i].ToUpper());
        }
    }

}