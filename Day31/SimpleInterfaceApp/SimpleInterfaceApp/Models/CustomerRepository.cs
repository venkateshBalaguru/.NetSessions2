using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    //sealed class DataAccess //This Sealed class can't inherit
    class CustomerRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer is Created in db");
        }

        public void Delete()
        {
             Console.WriteLine("Customer is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("Customer records are selected from db");
        }

        public void Update()
        {
            Console.WriteLine("Customer records are updated in db");
        }
    }
}
