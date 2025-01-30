using System;

namespace AccountCommonLibUsingHasA.Models
{
     public class Account
      {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private const double MINIMUM_BALANCE = 500;

        public Account(int accountNumber, string name, double balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
        }

        public Account(int accountNumber, string name) //overloaded constructor
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = MINIMUM_BALANCE;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
           
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount < MINIMUM_BALANCE)
            {
                var account = new Account(AccountNumber, _name, _balance);
                throw new InsufficientExceptionUsingHasA(account);
            }

                _balance -= amount;
         }

        public double Balance //To get the Balance
        { 
           get { return _balance; } 
        }

        public string Name // To get the AccountHolder
        {
            get { return _name; }
        }

        public int AccountNumber // To get the AccountNumber
        {
            get { return _accountNumber; }
        }
    }

}
