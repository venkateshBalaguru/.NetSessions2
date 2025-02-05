using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCommonLib.Models
{
    public class NewYearFD : FixedDeposit
    {
        public NewYearFD(int accno, string name, double princple, int duration) : base(accno, name, princple, duration)
        {
        }
        public override double CalcualteRate()
        {
            return .15;
        }
    }
}
