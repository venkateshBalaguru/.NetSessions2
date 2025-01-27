using AccountPolymorphism.Models;
using System;
using System.Runtime.CompilerServices;

namespace AccountPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingAccount savingAccount1 = new SavingAccount("101", "abc", 1000);
            //PrintDetails(savingAccount1);


            //var savingAccount2 = new CurrentAccount("101", "abc", 1000);
            //PrintDetails(savingAccount2);
            CaseStudy1(); //This is polymorphism style
        }

        private static void CaseStudy1()
        {
            //This can be done if the class is not abstract that means the acc1 is an not in Saving type and current type
            //So that the reaseon we but abstract on Parent class then we can't create a object in that class
            //Account acc1 = new Account("1","cc",5000);
            //acc1.Withdraw(1000);
            //PrintDetails(acc1);

            Account venkatAccount; //Abstract class only expects only subclasses;
            venkatAccount = new SavingAccount("AC101","Venkatesh",50000);
            PrintDetails(venkatAccount);
            
            Account sachinAccount; //Abstract class only expects only subclasses;
            sachinAccount = new CurrentAccount("AC102", "Sachin", 20000);
            PrintDetails(sachinAccount);

            venkatAccount.Withdraw(49000);
            PrintDetails(venkatAccount);

            sachinAccount.Withdraw(24000);
            PrintDetails(sachinAccount);
        }
        //OCP-->OpenClosedPrinciple
        //Open for adding new features,without modifying existing tested code
        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Account Type is " + account.GetType().Name); //This is inbuild method
            Console.WriteLine("Account Number : " + account.Id);
            Console.WriteLine("Account Holder Name : " + account.Name);
            Console.WriteLine("Balance : "+ account.Balance);
            Console.WriteLine("Type of Account is : "+account.Type); //Here we create a abstract properties in main class and we inherited in subclasses
            Console.WriteLine();

            //To find the Account type in Account class we using account.GetType().Name instead this we can do as shown below
            //This is not advisable because in future we can add Account types like demand Account..etc
            //if (account is SavingAccount)
            //{
            //    Console.WriteLine("This is Saving Account");
            //}
            //else
            //{
            //    Console.WriteLine("This is Current Account");
            //}
        }

    }
}
