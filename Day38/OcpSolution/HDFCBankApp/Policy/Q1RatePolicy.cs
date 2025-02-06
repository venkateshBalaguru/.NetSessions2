using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDCommonLib.Models;

namespace HDFCBankApp.Policy
{
    internal class Q1RatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            //complex algo
            return 0.07;
        }
    }
}