using System;

class PrintNameReverseUsingFunction
{
    static void Main(string[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments Passed, Pls pass the arguments");
            return;
        }
        PrintNameInStraight(userNames);
        PrintNameInReverse(userNames);
    }
    static void PrintNameInStraight(string[] userNames)//Straight order printing the names
    {
        Console.WriteLine("The Names are in Straight Order:\n");
        for (int i = 0; i < userNames.Length; i++)
        {
            Console.WriteLine("Hi Welcome: " + userNames[i]);
        }
    }
    static void PrintNameInReverse(string[] userNames)//Reverse order printing the names
    { 
        Console.WriteLine("\nThe Names are in Reverse Order: \n");
        for (int i = userNames.Length - 1; i >= 0; i--)
        {

            Console.WriteLine("Hi RRD Folks!==>" + userNames[i].ToUpper());
        }
    }

}
