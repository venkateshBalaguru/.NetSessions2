using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofactoryCommonLib.Products
{
    internal class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla Starts the car....");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stops the car....");
        }
    }
}
