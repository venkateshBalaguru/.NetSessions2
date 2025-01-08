using System;
using System.Net.Http.Headers;
class Program
{
    static void Main()
    {

        PrintNameValidator();
    }
    static void PrintNameValidator()
    {

        while (true)
        {
            Console.WriteLine("Hi Welcome to RRD==>Enter your Name :");
            string name = Console.ReadLine();
            if (IsValid(name))
            {
                Console.WriteLine($"The Given Name in Correct format : {name}! Good Day");
                break;
            }
            Console.WriteLine("The Name should be only in Alphabets Dont use numbers, special characters and Blank");

        }
    }
    static bool IsValid(string name)
    {
        if (name == "")
        {
            return false;
        }
        foreach (char c in name)
        {
            if ((c < 65 || c > 90) && (c < 97 || c > 122))
                return false;
        }
        return true;
    }
}