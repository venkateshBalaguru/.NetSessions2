using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppInArray.Models
{
    class Account
    {
        private readonly int _accountNumber;
        private readonly string _accountName;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private const double HIGH_BALANCE = 20000;
        private const int LONG_NAME_LENGTH = 6;

        public Account(int accountNumber, string accountName, double balance)
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _balance = balance;
        }

        public Account(int accountNumber, string accountName)
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _balance = MIN_BALANCE;
        }

        public double Balance
        {
            get { return _balance; }

        }

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public string AccountName
        {
            get { return _accountName; }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount > MIN_BALANCE)
            {
                _balance -= amount;
            }
        }

        public String RichestAccountHolder()
        {
            if (_balance > HIGH_BALANCE)
            {
                return $"Richest Account Holder!";
            }
            return "";
        }

        public string LongestNameAccountHolder()
        {
            if (_accountName.Length > LONG_NAME_LENGTH)
            {
                return $"Longest Name Account Holder!";
            }
            return "";
        }
    }
}

