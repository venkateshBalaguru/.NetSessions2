using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryCommonLib.Services
{
    internal class SavingAccount : IAccount
    {
        public void AccountType()
        {
            Console.WriteLine("This is Saving Account"); ;
        }
    }
}
