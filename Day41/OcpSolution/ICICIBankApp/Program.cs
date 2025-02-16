using ICICIBankApp.Policy;
using FDCommonLib.Models;

namespace ICICIBankApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            var fd1 = new FixedDeposit(101, "abc", 10000, 10, new DiwaliPolicy().CalculateRate);
            Console.WriteLine(fd1.SimpleInterest);

            var fd2 = new FixedDeposit(101, "abc", 10000, 10, new NewYearPolicy().CalculateRate);
            Console.WriteLine(fd2.SimpleInterest);

        }
    }


}
