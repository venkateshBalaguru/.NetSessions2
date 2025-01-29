﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class InsufficientFundsException : Exception
    {
        //private Account _accountHolder;//HasA relationship

        //public InsufficientFundsException(Account account) 
        //{ 

        //   _accountHolder = account;
        //}
        // public override string Message {
        //     get {

        //         return $"account holder:{_accountHolder.Name} , doesnot have sufficends for withraw of balacne is only ${_accountHolder.Balance}";
        //     }
        // }

        private string _holdername;
        private double _balance;
        //public InsufficientFundsException(string holdername, double balance):base($"From Inheritance method ==>account holder:{holdername} , does not have sufficient for withdraw of balance is only :{balance}")
       public InsufficientFundsException(string holdername, double balance) //This is polymorphic type we have use the override from the Exception class Message
        {
            _holdername = holdername;
            _balance = balance;
        }

        public override string Message //If we comment this method we can pass the error msg through the Inheritance type using the constructor
        {
            get
            {
                return $"account holder:{_holdername} , does not have sufficient for withdraw of balance is only :{_balance}";
            }
        }


    }


}