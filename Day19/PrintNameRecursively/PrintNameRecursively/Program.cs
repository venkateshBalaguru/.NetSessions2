using System;
class PrintNameRecursively
{
    static void Main() //main Function
    {
        PrintName(1);
    }
    static void PrintName(int number) //Recursive print function
    {   
        if(number <= 10) //condition to print the name 10 times
        {
            
            Console.WriteLine($"Hi! I am Venkatesh | {number}");
            number++;
            PrintName(number);
        }
        
       
    }
}
