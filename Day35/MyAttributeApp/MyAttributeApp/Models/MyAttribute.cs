using System;
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
        public void Method1() {  }
        public void Method2() {  }
        public void Method3() {  }
        [ThisMethodNeedsAttention]
        public void Method4() {  }

    }
}
