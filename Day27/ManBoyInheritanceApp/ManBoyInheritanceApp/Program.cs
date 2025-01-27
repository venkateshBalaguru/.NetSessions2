using System;
using ManBoyInheritanceApp.Models;

namespace ManBoyInheritanceApp
{
    // If it is in structure it is a value type  there no reference address
    //struct Point
    //{

    //    public int x;
    //    public int y;

    //}
//It is class type so it is a reference type
class Point
{
    public int x;
    public int y;
}

internal class Program
        {
            static void Main(string[] args)
            {
                //CaseStudy1(); //Man class 

                //CaseStudy2();// child inherited the Man class method

                //CaseStudy3();// child override the methods 

                //CaseStudy4(); //Polymorphic method

                CaseStudy5(); //Highest type of polymorphism is using Object class

                //CaseStudy6();
            }

        private static void CaseStudy6()
        {
            Point p1 = new Point(); //VAlueType Inheritance
            p1.x = 10;
            p1.y = 20;

            Point p2 = p1;//create copy in stack
            p2.x = 100;
            

            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            Console.WriteLine(p1.x);

            int no1 = 100;
            int no2 = no1;
            Console.WriteLine(no1);
            Console.WriteLine(no2);

        }

        private static void CaseStudy5()
        {
            Object box;
            box = "Hello";
            Console.WriteLine(box.GetType());
            box = 100; //boxing
            Console.WriteLine(box.GetType());
            //int result = box; // we can't perform this because here box is not a integer variable its an a object type.
            int result = (int)box;//Unboxing the object type to integer type
            result++;
            Console.WriteLine(result);

            box = new Boy(); //Here we can make a box as object because it is basically object type
            Console.WriteLine(box.GetType());

            //box.play();//we can't do that we have to unbox
            var boy = (Boy)box; //unboxing
            boy.Play();


        }

        private static void CaseStudy4() //Polymorphic method
        {
            AtThePark(new Man()); //passing Man type
            AtThePark(new Boy()); // Passing the child type
            AtThePark(new Infant());
            AtThePark(new Toddler());


        }

        private static void AtThePark(Man x) //The X expects the Man type (we can use any child parent of Man
        {
            Console.WriteLine("At the park!!");
            x.Play();
                      
        }
        

        private static void CaseStudy3()
        {

            Man x;// x expects (ISA a typeof Man)
            x = new Boy(); //Here we put Boy class in the Man because Man is parent in the Parent class we can use child
            x.Play(); //But we call the Man class method only we can't call Boy's method (because the compiler will give the types of x is Man class method
            x.Read();
            
            //x.Write(); //we can't call the method Boy class
        }

        private static void CaseStudy2()
        {
            var boy = new Boy();
            boy.Read();
            boy.Write();
            boy.Play();//who plays==> Boy plays
        }

        private static void CaseStudy1()
            {
                Man man1;// man1 expects a Man type
                man1 = new Man();
                man1.Play();
                man1.Read();
            }
        }

    }
