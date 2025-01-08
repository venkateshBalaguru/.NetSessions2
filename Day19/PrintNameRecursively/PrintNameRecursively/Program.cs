using System;
class PrintNameRecursively
{
    static void Main() //main Function
    {
        //PrintName(1); //Function call with argument by increement
        PrintName(10); //Function call with argument by decreement
    }
    static void PrintName(int number) //Print function
    {   
        //if(number <= 10) //condition to break the function
        //{
            
        //    Console.WriteLine($"Hi! I am Venkatesh | {number}");
        //    number++;
        //    PrintName(number);// (function called itself is called Recursive)
        //}

        if (number == 0)
            return;
        Console.WriteLine($"Hi! I am Venkatesh | {number}");
        PrintName(number - 1);
    }
}
