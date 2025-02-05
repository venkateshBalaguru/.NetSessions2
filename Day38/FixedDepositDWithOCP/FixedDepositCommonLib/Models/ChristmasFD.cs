using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDepositCommonLib.Models
{
    public class ChristmasFD : FixedDeposit
    {
        public ChristmasFD(int accno, string name, double princple, int duration) : base(accno, name, princple, duration)
        {
        }
        public override double CalcualteRate()
        {
            return .12;
        }
    }

}
