using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDCommonLib.Models;

namespace HDFCBankApp.Policy
{
    internal class Q2RatePolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}