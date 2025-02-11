using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryCommonLib.Services
{
    public class AccountFactory
    {
        public IAccount CreateAccount(AccountType type)
        {
            if (type == AccountType.Saving)
            {
                return new SavingAccount();
            }
            if (type == AccountType.Current)
            {
                return new CurrentAccount();
            }
            throw new ArgumentException("Invalid account ype");
        }
    }
}