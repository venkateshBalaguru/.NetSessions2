using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Models
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man is saying Good Bye...");
        }

        public void Wish()
        {
               Console.WriteLine("Man is saying Good Morning...");
        }
        public void Walk()
        {
            Console.WriteLine("Man is walking");
        }
    }
}
