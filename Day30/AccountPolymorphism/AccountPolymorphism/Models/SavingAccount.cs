using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string id, string name, double balance) : base(id, name, balance)
        {
        }

        public override string Type
        {
            get { return "Saving Account"; }
        }

        public override void Withdraw(double amount)
        {
            if(_balance - amount < 1000) //Fail early 
            {
                var ex = new Exception("NO funds,min balance 1000");
                throw ex;
                //throw new Exception("Insufficient Funds, You have to maintain Minimum Balance 1000 ");//anonyms instance of Exception class
            }
            _balance = _balance - amount;
        }
    }
}
