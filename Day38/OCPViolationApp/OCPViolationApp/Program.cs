using OCPViolationApp.Models;
namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit(10571, "venkatesh", 10000, 12, FestivalType.Diwali);
            Console.WriteLine(fd1.SimpleInterest);
        }
    }
}
