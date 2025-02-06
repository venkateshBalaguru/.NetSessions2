using DIPConsoleViolationApp.HighlLevel;

namespace DIPConsoleViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var calc = new TaxCalculator(LogType.EMAIL);

            //Console.WriteLine(calc.CalculateTax(10000, 20));
            Console.WriteLine(calc.CalculateTax(10000, 0));

            //var calc2 = new TaxCalculator(LogType.TEXT);

            //Console.WriteLine(calc.CalculateTax(10000, 20));
            ////Console.WriteLine(calc2.CalculateTax(10000, 0));
        }
    }
}