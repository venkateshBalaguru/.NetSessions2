using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeDesignPattern_FilesForlders.Models
{
    public class Leaf : IComponent
    {
        private string _name;
        public Leaf(string name) 
        {
            _name = name;
        }

        public  void Display()
        {
            Console.WriteLine(_name);
        }
    }
}

