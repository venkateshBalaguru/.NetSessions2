using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDCommonLib.Models;

namespace ICICIBankApp.Policy
{
    internal class NewYearPolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            //complext aglo
            return 0.12;
        }
    }
}