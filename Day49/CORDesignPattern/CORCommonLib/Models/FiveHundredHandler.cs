using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CORCommonLib.Models
{
    public class FiveHundredHandler : Handler
    {
        public override string DispatchNote(long requestedAmount)
        {
            string result;
            long numberOfNotesTobeDispatched = requestedAmount / 500;
            if (numberOfNotesTobeDispatched >= 1) 
            {  
                result = numberOfNotesTobeDispatched + " Five Hundred notes are dispatched\n";
            }
            else { result = string.Empty; }
            long pendingAmount = requestedAmount % 500;
            if (pendingAmount > 0) 
                result += NextHandler.DispatchNote(pendingAmount);
            return result;
        }
    }
}
