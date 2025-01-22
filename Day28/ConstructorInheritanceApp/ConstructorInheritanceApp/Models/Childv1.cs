using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Models
{
    internal class ChildV1 : ParentV1
    {

        public ChildV1()
        {
            Console.WriteLine("ChildV1 created");
            
        }
        //public ChildV1() : base() //base() default its there but its hidden
        //{
        //    Console.WriteLine("Childv1 created");
        //}
    }
}