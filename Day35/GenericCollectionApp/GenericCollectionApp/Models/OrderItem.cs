using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionApp.Models
{
    internal class OrderItem
    {
        //We can use this type for DTO-Data Transfer Object, serialization, Deserialization Restful API's and Web Development
        //We can do like this also there is no Encapsulation and no validation for the setter
        //Advantage is we can directly initialize from the property syntax, we can pass from any order check the program.cs
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quanity { get; set; }


        public double LineItemCost
        {
            get
            {
                return Quanity * UnitPrice;
            }
        }

        public override string ToString()
        {
            return $" Id is {this.Id} | Name is {this.Name} | Quantity : {this.Quanity} | Unit price : {this.UnitPrice} | Line Item cost : {this.LineItemCost}";
        }

    }
}
