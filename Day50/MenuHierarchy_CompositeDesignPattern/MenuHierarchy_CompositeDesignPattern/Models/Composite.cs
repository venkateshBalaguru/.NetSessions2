using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuHierarchy_CompositeDesignPattern.Models
{
    public class Composite : IComponent
    {
        public List<IComponent> Children =new List<IComponent>();
        public string productName;
        public Composite(string menuName)
        {
            this.productName = menuName;
        }

        public void Add(IComponent component)
        {
            Children.Add(component);
        }
            
        public void Display()
        {
            Console.WriteLine(productName);
            foreach (var child in Children)
            {
                child.Display();
            }
        }
    }
}
