using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceApp.Models
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man saying Good Bye...");
        }

        public void Wish()
        {
            Console.WriteLine("Man saying Good Morning...");
        }
    }
}
