using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributeApp.Models
{
   internal class Test
    {
        [ThisMethodNeedsAttention]
        public void Method1() { Console.WriteLine("I am Method-1"); }
        public void Method2() { Console.WriteLine("I am Method-2"); }
        public void Method3() { Console.WriteLine("I am Method-3"); }
        [ThisMethodNeedsAttention]
        public void Method4() { Console.WriteLine("I am Method-4"); }

    }
}
