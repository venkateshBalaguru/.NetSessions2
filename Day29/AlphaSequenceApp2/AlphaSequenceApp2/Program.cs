using System.Xml.Linq;
using AlphaSequenceApp2.Models;
namespace AlphaSequenceApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "az", "baca", "ad", "AB", "Aba" };
            Sequence.SequenceAlphabet(names);
            
        }

        public static void PrintDetails(bool result)
        {
            Console.WriteLine("Finding the given names IsCorrect alphabet sequence");
            Console.WriteLine("===================================================");
            
                if (result)
                {
                    Console.WriteLine($"The Given Name  IsSequence==> {result}");
                }
                else
                {
                    Console.WriteLine($"The Given Name  IsSequence==> {result}");
                }

        }
    }
}
