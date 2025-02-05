using FixedDepositCommonLib.Models;

namespace ABCBanck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit(102, "Guru", 10000, 12);
            Console.WriteLine("ABC Bank Normal-Days FD : "+fd1.SimpleInterest);
            var fd2 = new DiwaliFD(102,"Guru",10000,12);
            Console.WriteLine("ABC Bank Diwali FD Offer : " + fd2.SimpleInterest);
            var fd3 = new ChristmasFD(102, "Guru", 10000, 12);
            Console.WriteLine("ABC Bank Christmas FD Offer : " + fd3.SimpleInterest);
            var fd4 = new NewYearFD(102, "Guru", 10000, 12);
            Console.WriteLine("ABC Bank New Year FD Offer : " + fd4.SimpleInterest);
        }
    }
}
