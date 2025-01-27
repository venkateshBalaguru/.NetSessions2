using System.Xml.Linq;
using AlphaSequenceApp2.Models;
namespace AlphaSequenceApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "az", "baca", "ad", "AB", "Aba" };
            Console.WriteLine("Finding the given names IsCorrect alphabet sequence");
            Console.WriteLine("===================================================");
            Sequence.SequenceAlphabet(names);
            
        }
    }
}
