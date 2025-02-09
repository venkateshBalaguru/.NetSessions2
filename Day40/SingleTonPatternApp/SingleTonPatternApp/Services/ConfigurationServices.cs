using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPatternApp.Services
{
    internal class ConfigurationServices
    {
        private static ConfigurationServices _bucket;
        public ConfigurationServices() 
        {
            Console.WriteLine("Service Created");
        }
        public void DoSomething()
        {
            Console.WriteLine("Fetching the Configuration Details from redis cache ==>"+ this.GetHashCode());
        }

        public static ConfigurationServices CreateInstance()
        {
            if (_bucket == null)
            {
                _bucket =  new ConfigurationServices();
            }
            return _bucket;
        }
    }
}
