using AccountCommonLibUsingHasA.Models;

namespace CustomExceptionErrorHandlingUsingHasA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Bala", 1000);
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
