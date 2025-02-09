using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofactoryCommonLib.Products
{
    public class AutoMobileFactory
    {
        public IAutomobile Make(AutoType msg)
        {
            if(msg == AutoType.Benz)
                return new Benz();
            else if (msg == AutoType.Tesla)
                return new Tesla(); 
            else 
                return new BMW();
        }
    }
}
