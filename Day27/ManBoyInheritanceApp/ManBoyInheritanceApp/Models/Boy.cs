using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
   internal class Boy : Man //inheriting the method, properties from man
    {
       
        public override void Play() // By using override we can Override the man's method if not use override keyword we can't override the method.
        {
            Console.WriteLine("Boy is Playing football");

        }

        public void Write()
        {
            Console.WriteLine("Boy is Writing");
        }
    }
}
