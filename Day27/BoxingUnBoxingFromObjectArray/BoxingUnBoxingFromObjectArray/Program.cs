using System;
using System.Diagnostics.CodeAnalysis;

namespace BoxingUnBoxingFromObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double sum = 0;
            double average = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                
                Console.Write("["+inputArray[i]+"]");
                sum = sum + (int)inputArray[i];
                average = sum / inputArray.Length;
            }
            
            Console.WriteLine();
            Console.WriteLine($"The sum of the Given Number is : {sum}");
            Console.WriteLine($"The average of the given number is {average}");
        }
    }
}
