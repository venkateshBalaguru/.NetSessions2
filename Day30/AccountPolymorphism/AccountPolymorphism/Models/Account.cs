using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
   abstract class Account  //In a abstract class we can have a non-abstract method
    {
        private string _id;
        private string _name;
        protected double _balance;

        //public Account() { }  //Default Constructor

        public Account(string id, string name, double balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public abstract string Type { get; }

        public void Deposit(double amount)
        {
            _balance = amount;
        }
        //public virtual void Withdraw(double amount) { }//This method can be override in the child class[It is equivalent to abstract class]
        public abstract void Withdraw(double amount); //This abstract method must be override
    
    }

}
