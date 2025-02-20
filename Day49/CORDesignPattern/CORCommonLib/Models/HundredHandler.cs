using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORCommonLib.Models
{
    public class HundredHandler : Handler
    {
        public override string DispatchNote(long requestedAmount)
        {
            string result;
            long numberOfNotesTobeDispatched = requestedAmount / 100;
            if (numberOfNotesTobeDispatched >= 1)
            {
                result = numberOfNotesTobeDispatched + " One Hundred notes are dispatched";
            }
            else { result = string.Empty; }
            return result;
        }
    }
}
