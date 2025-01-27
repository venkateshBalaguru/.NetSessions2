using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceApp.Models
{
    internal class Boy : IMannerable,IEmotionable
    {
        public void Depart()
        {
            Console.WriteLine("BOy saying Good Bye...");
        }

        public void Wish()
        {
            Console.WriteLine("Boy saying Good Morning...");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy laughing ...");
        }

        public void Cry()
        {
            Console.WriteLine("Boy  crying...");
        }
    }


}
