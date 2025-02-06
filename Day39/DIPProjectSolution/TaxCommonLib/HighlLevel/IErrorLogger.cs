using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCommonLib.HighlLevel
{
    public interface IErrorLogger
    {
        void Log(Exception ex);
    }

}
