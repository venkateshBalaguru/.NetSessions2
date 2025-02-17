using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern_FilesForlders.Models
{
    public abstract class AbstractFileSystemComponent
    {
        public string Name { get; set; }

        protected AbstractFileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }
}

