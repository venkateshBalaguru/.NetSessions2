using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositeDesignPattern_FilesForlders.Models
{
    internal class Folder : AbstractFileSystemComponent
    {
        private List<AbstractFileSystemComponent> _components = new List<AbstractFileSystemComponent>();

        public Folder(string name) : base(name) { }

        public void Add(AbstractFileSystemComponent component)
        {
            _components.Add(component);
        }

        public void Remove(AbstractFileSystemComponent component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}