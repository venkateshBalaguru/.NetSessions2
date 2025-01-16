using AccountApp.Models;
using System;
using System.Runtime.CompilerServices;
namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy1()
        {
            Account accountVenkat = new Account(10571, "Venkatesh", 5000);
            //Console.WriteLine(accountVenkat.AccountNumber);
            accountVenkat.Deposit(2000);
            PrintDetails(accountVenkat);
            accountVenkat.Withdraw(6000);
            PrintDetails(accountVenkat);
        }

        private static void CaseStudy2()
        {
            Account accountJaya = new Account(10572, "Jaya");//overloaded constructor in this method balance is set to default value 500(minimum balance)
            PrintDetails(accountJaya);
            accountJaya.Deposit(2000);
            PrintDetails(accountJaya);
        }

        private static void CaseStudy3()
        {
            PrintDetails(new Account(10573, "Rajesh", 10000)); //Anynomous object in this object we can't deposit and withdraw
            
        }
        public static void PrintDetails(Account account)
        {
            Console.WriteLine($"Name of Account Holder is {account.AccountHolder.ToUpper()} \nBalance Amount = {account.Balance}\nAccount Number is : {account.AccountNumber}");
            //Console.WriteLine("Account Number: " + account.AccountNumber());
            //Console.WriteLine("Account Holder: " + account.AccountHolder());
            //Console.WriteLine("Balance: " + account.Balance());
            //account.Deposit(2000);
            //Console.WriteLine($"After Deposit now the Balance:  {account.Balance()}");
            //account.Withdraw(7000);
            //Console.WriteLine("After Withdraw now the Balance: " + account.Balance());

        }
    }
}
