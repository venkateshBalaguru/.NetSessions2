﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerHashSetApp.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object other)
        {
            Customer second = (Customer)other;
            if (this.Id == second.Id && this.Name == second.Name)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"id is  {this.Id} , name is {this.Name}";
        }
    }
}