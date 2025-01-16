using AccountAppInArray.Models;
using System;

namespace AccountAppInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Account accVenkat = new Account(101, "Venkatesh", 100000);
            accVenkat.Withdraw(5000);
            Account accSachin = new Account(102, "Sachin", 5000);
            Account accJaya = new Account(103, "Jaya");
            accJaya.Deposit(5000);
            Account accShalini = new Account(104, "Shalini",25000);

            Account[] accounts = { accVenkat, accSachin, accJaya, accShalini };
            PrintDetails(accounts);
            //RichestAccountHolder(accounts);
            //LongestNameAccountHolder(accounts);
        }

        public static void PrintDetails(Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Account Name: {account.AccountName}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(account.RichestAccountHolder());
                Console.WriteLine(account.LongestNameAccountHolder());
                Console.ResetColor();
                Console.WriteLine();

            }
        }

        //public static void RichestAccountHolder(Account[] accounts)
        //{
        //    double MaxBalance = 20000;
        //    for (int i = 0; i < accounts.Length; i++)
        //    {
        //        if (accounts[i].Balance > MaxBalance)
        //        {
        //            Console.WriteLine($"\nRichest Account Holder is : {accounts[i].AccountName} ===> Balance Amount is {accounts[i].Balance}");
        //        }   
        //    }
        //}

        //public static void LongestNameAccountHolder(Account[] accounts)
        //{
        //    string longestName="";
        //    int LongestNameLength = 6;
        //    for (int i = 0; i < accounts.Length; i++)
        //    {
        //        if (accounts[i].AccountName.Length > LongestNameLength)
        //        {
        //            longestName = accounts[i].AccountName;
        //            Console.WriteLine($"\nLongest Name Account Holder is : {longestName}");
        //        }
        //    }
            
        //}
    }
}
