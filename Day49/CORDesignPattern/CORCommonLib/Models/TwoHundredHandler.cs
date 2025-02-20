using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORCommonLib.Models
{
    public class TwoHundredHandler : Handler
    {
        public override string DispatchNote(long requestedAmount)
        {
            string result;
            long numberOfNotesTobeDispatched = requestedAmount / 200;
            if (numberOfNotesTobeDispatched >= 1)
            {
                result = "The " + numberOfNotesTobeDispatched + " Two Hundred notes are dispatched\n";
            }
            else { result = string.Empty; }
            long pendingAmount = requestedAmount % 200;
            if (pendingAmount > 0)
                result += NextHandler.DispatchNote(pendingAmount);
            return result;
        }
    }
}
