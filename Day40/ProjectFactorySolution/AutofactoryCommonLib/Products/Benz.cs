using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofactoryCommonLib.Products
{
    internal class Benz : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("Benz Starts the car....");
        }

        public void Stop()
        {
            Console.WriteLine("Benz stops the car....");
        }
    }
}
