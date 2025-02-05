using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommonLib.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Address> Addresses { get; set; }

        //public Customer()
        //{
        //    Addresses = new List<Address> { };
        //}
        //public AddAddress(Address address)
        //{
        //    //This is for only if we keep the Addresses field as private 
        //}
    }
}


