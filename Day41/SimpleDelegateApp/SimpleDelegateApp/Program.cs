namespace SimpleDelegateApp
{
    delegate void DPrintMsg(string name);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();

            DPrintMsg x; //Assiging variable and passing the functions
          //  x = Hello;//named function 

            x = delegate (string name)
            {
                Console.WriteLine("I am Anonymous" + name);
            };

            //x=(n)=>{Console.WriteLine($"Hi iam " + n.ToUpper());}; //lamda function
            x("Venkatesh");

        }

        public static void CaseStudy3()
        {
            PrintWizard(Hello); //Named function
            PrintWizard(GoodBye1);//Named funciton
            PrintWizard(delegate (string name) { Console.WriteLine($"Hi to all I am anonymous function {name}"); });//Anonymous funcion
            //Lamda function
            PrintWizard((n) => { Console.WriteLine($"I am Lamda function{n}"); });


        }
        public static void CaseStudy2()
        {
            DPrintMsg x;
            x = Hello;
            x += GoodBye1;//It is like x.add
            x += Hello;//x.add
            x("Venkat");
        }

        public static void PrintWizard(DPrintMsg funPtrCallBack)
        {
            Console.WriteLine("Doing the printing operation");
            Console.WriteLine("Operation completed");
            funPtrCallBack("RRD Guys");
        }
        public static void CaseStudy1()
        {
            var y = new Program();
            DPrintMsg x; //x expects a function
            x = Hello;
            x("Sachin");
            x("Bala"); //Its is runtime we can pass differenct function
            x = y.GoodBye;//without using static method we can create instance of program class here y is instance of program class
            x("Minu");
            // x=GoodBye//we can assign if we made GoodBye method as static otherwise we have create object to call method...
           // x = Foo; //this will not work bcoz its not same signature

        }
       static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void GoodBye1(string name)
        {
            Console.WriteLine($"GOOD Bye {name}");
        }
        void GoodBye(string name)
        {
            Console.WriteLine($"Good Bye {name}");
        }
        static void Foo(int name)
        {
            Console.WriteLine("I am not match Bcoz I parameter data type is different");
        }
    }
}
