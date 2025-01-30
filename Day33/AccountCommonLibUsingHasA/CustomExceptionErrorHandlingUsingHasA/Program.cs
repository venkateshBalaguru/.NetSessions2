using AccountCommonLibUsingHasA.Models;

namespace CustomExceptionErrorHandlingUsingHasA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Bala", 3000);
            Account account2 = new Account(105, "Venkatesh", 5000);
            Account account3 = new Account(106, "Sachin", 6000);
            Account[] accounts = {account1, account2, account3};
            try
            {
                account1.Withdraw(1000);//risky
                account3.Withdraw(2000);
            }


            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            account2.Deposit(5000);
            //account3.Withdraw(2000);
            PrintDetails(accounts);
            Console.WriteLine("End of Main");
        }
        public static void PrintDetails(Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Acc No : {account.AccountNumber}\nName : {account.Name}\nBalance : {account.Balance}\n");
            }
        }
    }   
}
