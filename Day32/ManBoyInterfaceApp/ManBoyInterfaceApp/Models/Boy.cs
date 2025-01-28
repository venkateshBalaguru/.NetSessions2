    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Models
{
    internal class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy saying Good Bye");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy saying Good Morning");
        }
    }
}
