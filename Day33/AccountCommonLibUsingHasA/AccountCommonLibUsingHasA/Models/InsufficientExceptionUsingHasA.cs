using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLibUsingHasA.Models
{
    public class InsufficientExceptionUsingHasA : Exception
    {
        private Account _accountHolder;//HasA relationship

        public InsufficientExceptionUsingHasA(Account account)
        {

            _accountHolder = account;
        }

        public override string Message
        {
            get
            {
                return $"account holder:{_accountHolder.Name} , does not have sufficient for withdraw of balance is only :{_accountHolder.Balance}";
            }
        }


    }


}