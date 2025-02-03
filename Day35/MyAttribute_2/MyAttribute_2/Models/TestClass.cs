using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute_2.Models
{
    internal class TestClass
    {
        [ThisNeedAttention("This method needs Attention")]
        public static void Method1()
        {
            Console.WriteLine("Method_1 will Execute");
        }
        public static void Method2()
        {
            Console.WriteLine("Method_2 will Execute");
        }

        [ThisNeedAttention("This method needs Attention")]
        public static void Method3()
        {
            Console.WriteLine("Method_3 will Execute");
        }
        public static void Method4()
        {
            Console.WriteLine("Method_4 will Execute");

        }
    }
}
