﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerListGroupByLocation.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id, Name);
        //}

        //public override bool Equals(object other)
        //{
        //    Customer second = (Customer)other;
        //    if (this.Id == second.Id && this.Name == second.Name)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public override string ToString()
        //{
        //    return $"ID : {this.Id} | Name : {this.Name} | Location : {this.Location}";
        //}

    }
}
