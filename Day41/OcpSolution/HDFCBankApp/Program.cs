
using FDCommonLib.Models;
using HDFCBankApp.Policy;

namespace HDFCBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fd = new FixedDeposit(102, "Hdf customer1", 100000, 10, new Q1RatePolicy().CalculateRate); //We using the name function in delegates
            Console.WriteLine(fd.SimpleInterest);

            var fd1 = new FixedDeposit(102, "Hdf customer1", 100000, 10, () => { return 0.08; }); //lamda function in delegates
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}
