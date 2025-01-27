using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    class CurrentAccount : Account
    {
        public CurrentAccount(string id, string name, double balance) : base(id, name, balance)
        {
        }

        public override string Type
        {
            get { return "Current Account"; }
        }
        public override void Withdraw(double amount)
        {
            if (_balance - amount < -5000)
            {
                throw new Exception("Credit Limit is reached 5000!...");
            }
            _balance = _balance - amount;
        }
    }
}
