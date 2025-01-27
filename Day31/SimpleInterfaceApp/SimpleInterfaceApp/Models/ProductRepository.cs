using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    class ProductRepository : ICrudable
    {

        public void Create()
        {
            Console.WriteLine("Product is Created in db");
        }

        public void Delete()
        {
            Console.WriteLine("Product is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("Product records are selected from db");
        }

        public void Update()
        {
            Console.WriteLine("Product records are updated in db");
        }
    }
}
