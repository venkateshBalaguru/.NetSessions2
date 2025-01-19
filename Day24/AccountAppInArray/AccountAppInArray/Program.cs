using AccountAppInArray.Models;
using System;
using System.Net.Http.Headers;

namespace AccountAppInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new object for Account class

            Account accVenkat = new Account(101, "Venkatesh", 100000);
            Account accSachin = new Account(102, "Sachin", 5000);
            Account accJaya = new Account(103, "Jayapreethi");
            Account accShalini = new Account(104, "Shalini",25000);
            accVenkat.Withdraw(5000); //calling withdraw method
            accJaya.Deposit(5000); //calling deposit method

            //creating a Array of Account class
            Account[] accounts = { accVenkat, accSachin, accJaya, accShalini };
            Account.Transfer(accVenkat, accSachin, 5000); //calling Transfer method to transfer amount from one account to another account with aruguments
            PrintDetails(accounts); //calling PrintDetails method to print the details of account holders

            //RichestAccountHolder(accounts);
            //LongestNameAccountHolder(accounts);
        }
        //Method to print the details of account holders
        public static void PrintDetails(Account[] accounts)
        {
            int customerCount = 1;
            foreach (Account account in accounts)
            {
                Console.WriteLine("===================================");
                Console.WriteLine($"Customer {customerCount++}");
                Console.WriteLine("===================================");
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Account Name: {account.AccountName}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.ForegroundColor = ConsoleColor.Green;

                //calling RichestAccountHolder and LongestNameAccountHolder methods to check the conditions and print the details
                if (account.RichestAccountHolder())
                {
                    Console.WriteLine("Richest account Holder");
                }
                if (account.LongestNameAccountHolder())
                {
                    Console.WriteLine("Longest Name Holder");
                }

                //Console.WriteLine(account.RichestAccountHolder());
                //Console.WriteLine(account.LongestNameAccountHolder());
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
        //    string longestName = "";
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
