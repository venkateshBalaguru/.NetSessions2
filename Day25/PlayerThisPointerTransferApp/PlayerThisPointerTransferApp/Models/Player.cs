using System;
using System.Runtime.CompilerServices;

namespace PlayerThisPointerTransferApp.Models
{
    class Player
    {
        private string name;
        private int age;
        private int accountNumber;
        private double balance;
        private const double MIN_BALANCE = 1000.00;

        public Player(string name, int age, int accountNumber, double balance)
        {
            this.name = name;
            this.age = age;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public Player(string name, int age, int accountNumber): this(name, age, accountNumber, MIN_BALANCE)
        {

        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance - amount >= MIN_BALANCE)
            {
                balance -= amount;
            }

        }
        public int Age
        {
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        //public Player Transfer(Player secondPlayer, double amount)
        //{
        //    if (this.balance - amount >= MIN_BALANCE)
        //    {
        //        this.balance -= amount;
        //        secondPlayer.Deposit(amount);
        //    }
        //    return secondPlayer;
        //}

        public Player Transfer(Player secondPlayer, double amount)
        {
            if (balance - amount >= MIN_BALANCE)
            {
                balance -= amount;
                secondPlayer.Deposit(amount);
            }
            return secondPlayer;
        }
    }
}
