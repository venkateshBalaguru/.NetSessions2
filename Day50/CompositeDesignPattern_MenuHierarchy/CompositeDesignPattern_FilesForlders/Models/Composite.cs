using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeDesignPattern_FilesForlders.Models
{
    public class Composite : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();
        private string _name;
        public Composite(string name) 
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }

        public  void Display()
        {
            Console.WriteLine(_name);
            foreach (var child in _components)
            {
                child.Display();
            }
        }
    }
}