﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributeApp.Models
{
    class ThisMethodNeedsAttentionAttribute : Attribute { }
    internal class MyAttribute
    {
        [ThisMethodNeedsAttention]
        public void Method1() { Console.WriteLine("M1"); }
        public void Method2() { Console.WriteLine("M2"); }
        public void Method3() { Console.WriteLine("M3"); }

        [ThisMethodNeedsAttention]
        public void Method4() { Console.WriteLine("M4"); }

    }
}
