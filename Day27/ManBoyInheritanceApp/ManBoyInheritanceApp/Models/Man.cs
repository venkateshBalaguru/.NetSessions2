using System;
namespace ManBoyInheritanceApp.Models
{
    class Man
    {
        //public void Play()  //By default not override in c# (In java it will override in default)
        //{ 
        //    Console.WriteLine("Man is Playing Cricket"); 
        //}

        //By using Virtual can be override in the derived class
        public virtual void Play()
        {
            Console.WriteLine("Man is Playing Cricket");
        }

        public void Read() 
        { 
            Console.WriteLine("Man is Reading Books.."); 
        }    
    }
}
