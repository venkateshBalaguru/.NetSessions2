using DIPConsoleViolationApp.HighlLevel;
using DIPConsoleViolationApp.LowLevel;

namespace TaxConsoleInfraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var calc = new TaxCalculator(new TextLogger());
            Console.WriteLine(calc.CalculateTax(10000, 2));
        }
    }
}