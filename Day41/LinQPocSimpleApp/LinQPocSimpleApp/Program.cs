using System.ComponentModel.DataAnnotations;

namespace LinQPocSimpleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] names = { "Venkatesh", "Velu", "Deva", "Bala", "Veera", "venkat","Sachin" };

            //DisplayOddNumber(numbers);
            DisplayNameStartWithS(names);
        }

        private static void DisplayNameStartWithS(string[] names)
        {
            //var outputName = from name in names
            //                 where name.StartsWith("V")
            //                 select name;

            //using Lamda function
            //var outputName = names.Where(name => name.StartsWith("V")).OrderBy(name => name).ToList();
            var outputName = names.Where(name => name.StartsWith("V")).ToList(); // Directly to List
            //var outputName = names.Where(name => name.StartsWith("V")); 
            foreach (var name in outputName)
            {
                Console.WriteLine(name);
            }
        }

        private static void DisplayOddNumber(int[] numbers)
        {
            var OddNumber = from number in numbers 
                            where number % 2 == 1 
                            select number;
            foreach (var number in OddNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
