using System.Security.Principal;
using AccountCommonLib.Models;

namespace CustomExceptionHandlerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account(10571,"venkatesh", 1000);
            try
            {
                account1.Withdraw(1000);//risky
            }
            //catch(InsufficientFundsException ex) //This will also work
            catch (Exception ex)//ex expects object of Exception or subclasses of Exception
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
           
            Console.WriteLine("End of Main");
        }
    }
}
