using System.Numerics;
using CalCommonLib.Exceptions;
using CalCommonLib.Models;

namespace CalConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calc =  new Calculator();
            try
            {
                Console.WriteLine($"The result is  : {calc.CubeEventNo(3)}"); //we can print the output here itself using the cw
                calc.PositiveNumberAddition(5, 5);
            }
            //catch (NotAnEvenNumberException ex) //we can keep like this but no need all the exception parent itself catch
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //We can't keep the Exception like that Above we have the Parent Exception so we can't keep the child Exception
            //after the Parent Exception we can keep the child Exception before the child because the parent will catch all the
            //Exception then we don't need child this line will become unreached line so its show error
            //catch (NotAnEvenNumberException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.WriteLine("End of Main");
        }
    }
}
