using System.Data.SqlTypes;
using SingleTonPatternApp.Services;

namespace SingleTonPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var s1 = new ConfigurationServices();//It will create a new instance and do the process in the method
            //s1.DoSomething();
            //Console.WriteLine(s1.GetHashCode());

            //var s2 = new ConfigurationServices();
            //s2.DoSomething();
            //Console.WriteLine(s2.GetHashCode());

            // Instead above 
            var s1 = ConfigurationServices.CreateInstance();
            s1.DoSomething();

            var s2 = ConfigurationServices.CreateInstance();
            s2.DoSomething();
        }
    }
}
