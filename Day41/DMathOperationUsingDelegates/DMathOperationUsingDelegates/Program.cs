using System.ComponentModel;

namespace DMathOperationUsingDelegates
{
    delegate void DmathOper(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();

        }
        public static void CaseStudy1()
        {
            DmathOper action;
            action = Add;
            action += Minus;
            action += Multiply;
            action(10, 2);
        }
        public static void CaseStudy2()
        {
            DmathOper action;
            action = (int x, int y) => { Console.WriteLine($"Moudlus of {x} and {y} = {x % y}"); };
            action(11, 2);
            action = (int x, int y) => { Console.WriteLine($"Division of {x} and {y} = {x / y}"); };
            action(12, 6);
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} = {x+y}");
        }
        public static void Minus(int x, int y)
        {
            Console.WriteLine($"Subraction of {x} and {y} = {x - y}");
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} = {x * y}");
        }

    }
}
