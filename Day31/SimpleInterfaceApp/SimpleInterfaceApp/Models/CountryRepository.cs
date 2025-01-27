using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    internal class CountryRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Country is Created in db");
        }

        public void Delete()
        {
            Console.WriteLine("Country is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("Country records are selected from db");
        }

        public void Update()
        {
            Console.WriteLine("Country records are updated in db");
        }
    }
}
