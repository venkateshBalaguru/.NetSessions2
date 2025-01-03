using System;
class Hello
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the Number to print How many times you want");
        int No = Convert.ToInt32(Console.ReadLine());
            
        for (int i = 0; i < No; i++)
        {
            Console.WriteLine("Hello, World!");
        }
        }
    }

