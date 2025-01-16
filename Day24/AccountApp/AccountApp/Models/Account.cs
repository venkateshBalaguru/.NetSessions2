using System;

namespace AccountApp.Models
{
     class Account
    {
        private readonly int _accountNumber;
        private readonly string _accountHolder;
        private double _balance;
        private const double MINIMUM_BALANCE = 500;

        public Account(int accountNumber, string accountHolder, double balance)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;
        }

        public Account(int accountNumber, string accountHolder) //overloaded constructor
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = MINIMUM_BALANCE;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
           
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount > MINIMUM_BALANCE)
            {
                _balance -= amount;
            }

            //Error throwing but we can't use the print details method in the Account class
            //else
            //{
            //    Console.WriteLine("Insufficient Balance You can't withdraw this much of amount");
            //}

        }
        public double Balance //To get the Balance
        { 
           get { return _balance; } 
        }

        public string AccountHolder // To get the AccountHolder
        {
            get { return _accountHolder; }
        }

        public int AccountNumber // To get the AccountNumber
        {
            get { return _accountNumber; }
        }
    }

}
