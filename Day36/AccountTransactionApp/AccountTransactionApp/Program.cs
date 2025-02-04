using System.Security.Principal;
using System.Transactions;
using AccountTransactionApp.Models;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();

        }
        private static void CaseStudy1()
        {
            Account acc1 = new Account(1001, "Minu", 5000);
            acc1.Deposit(1000);
            acc1.Deposit(1000);
            acc1.Withdraw(2000);
            acc1.Deposit(5000);
            PrintDetails(acc1);
        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine($"name is {account.Name} balance is {account.Balance} and account is {account.AccountNumber}");

            //display txn summary

            List<TransactionAccount> allTxns = account.Transactions;

            foreach (TransactionAccount txn in allTxns)
            {
                Console.WriteLine($"type is :{txn.Type} amount  {txn.Amount} date is  {txn.Date}");
            }

        }

    }
}