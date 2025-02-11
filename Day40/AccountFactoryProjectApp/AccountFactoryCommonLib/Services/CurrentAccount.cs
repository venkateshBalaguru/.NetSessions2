using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryCommonLib.Services
{
    internal class CurrentAccount : IAccount
    {
        public void AccountType()
        {
            Console.WriteLine("This is Current Account");
        }

    }
}
