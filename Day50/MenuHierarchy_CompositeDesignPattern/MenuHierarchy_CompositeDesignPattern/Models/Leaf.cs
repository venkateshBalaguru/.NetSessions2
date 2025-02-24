using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHierarchy_CompositeDesignPattern.Models
{
    public class Leaf : IComponent
    {
        public string productName;

        public Leaf(string menuName) 
        {
            productName = menuName;
        }
        public void Display()
        {
            Console.WriteLine(productName); 
        }
    }
}
