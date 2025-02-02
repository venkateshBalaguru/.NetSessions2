using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;
using CustomerHashSetApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CustomerHashSetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {

            var c1 = new Customer { Id = 1, Name = "Venakt" };
            var c2 = new Customer { Id = 1, Name = "Venakt" };

            var c3 = new Customer { Id = 2, Name = "Minu" };
            var c4 = new Customer { Id = 2, Name = "Minu" };


            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());
            //Console.WriteLine(c3.GetHashCode());
            //Console.WriteLine(c4.GetHashCode());

            var uniqueCustomers = new HashSet<Customer>();
            uniqueCustomers.Add(c1);
            uniqueCustomers.Add(c2);
            uniqueCustomers.Add(c3);
            uniqueCustomers.Add(c4);

            Console.WriteLine(uniqueCustomers.Count);
        }

        private static void CaseStudy1()
        {

            var userNames = new HashSet<string>();
            userNames.Add("Venkat");
            userNames.Add("venkat");
            userNames.Add("Minu");
            userNames.Add("Minu");

            Console.WriteLine(userNames.Count);
            Console.WriteLine("Venkat".GetHashCode());
            Console.WriteLine("Venkat".GetHashCode());
            Console.WriteLine("venkat".GetHashCode());

            foreach (string name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
  //< h2 > Day27 </ h2 >
  //  < ol >
  //      < li >< a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day27/ManBoyInheritanceApp" > Inheritance and Polymorphism casestudy</a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day27/BoxingUnBoxingFromObjectArray">Lab - Boxing and Unboxing App </a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day26/ArrayOutputModify">Lab - Longest Name in the Array</a></li>
  //  </ol>
  //  <h2>Day28</h2>
  //  <ol>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day28/EqualityApp">Equality (==) and Equals override App</a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day28/ConstructorInheritanceApp">Constructor Inheritance </a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day28/NextLetterAlphaApp">Lab - Name next Letter App</a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day28/ReflectionDisplayTypeOf">Lab - Display Class Members Types and Names</a></li>
  //  </ol>
  //  <h2>Day29</h2>
  //  <ol>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day29/AlphabetSequenceApp">Lab - Alphabet sequence IsCorrect</a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day29/AlphaSequenceApp2">Lab - Alphabet sequence Iscorrect In OOP </a></li>
  //  </ol>
  //  <h2>Day30</h2>
  //  <ol>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day30/AccountPolymorphism">AccountApp using Abstract</a></ li >
  //      < li >< a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day30/AdjacentElementsProducts" > Lab - Adjacent Element Products</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day30/EmployeeAbstractionApp" > Lab - EmployeeApp using  Abstract </a></ li >
  //  </ ol >
  //  < h2 > Day31 </ h2 >
  //  < ol >
  //      < li >< a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day31/SimpleInterfaceApp" > Single Interface App</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day31/MultiInterfaceApp" > Lab - Multi Interface App </a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day31/SumOfAlternateNumbers" > Lab - Sum of Alternate numbers</a></li>
  //  </ol>
  //  <h2>Day32</h2>
  //  <ol>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day32/ManBoyInterfaceApp" > Man Boy Interface App</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day32/MovableInterface" > Movable - Vehicle Interface App </a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day32/ExceptionGenerateApp" > Exception & Syntax Error Handling </a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day32/ReverseStringInSameArray" > Lab - Reverse String in Same Array </a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day32/StreamWriterFileStreamApp" > Stream Writer and File stream App</a></li>
  //  </ol>
  //  <h2>Day33</h2>
  //  <ol>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day33/ExceptionPropagationAndErrorHandling" > Exception Propagation Error Handling App</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day33/CustomExceptionProSolution" > Custom Exception Project Solution using Common Library Using IsA</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day33/AccountCommonLibUsingHasA" > Lab - Custom Exception Project Solution using Common Library Using HasA</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day33/RotateElements" > Lab - Rotate the Elements by user input times </a></li>
  //  </ol>
  //  <h2>Day34</h2>
  //  <ol>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day34/CalcProjectSolution" > Calculation Project Solution using Business and Presentation Layer</a></li>
  //      <li><a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day34/CollectionApp" > Collection App using ArrayList </a></ li >
  //      < li >< a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day34/CalculateHumanBMI" > Lab - Calculate Human BMI and throw Exception using ArrayList</a></ li >
  //  </ ol >
  //  < h2 > Day35 </ h2 >
  //  < ol >
  //      < li >< a href = "https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day35/GenericCollectionApp" > Generic Collection App- List<T></t></a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day35/CustomerHashSetApp">Customer Hashset App - Hashset<string></string></Hashset></a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day35/SplitingString">Lab - Spliting String without Inbuild function</a></li>
  //      <li><a href="https://github.com/venkateshBalaguru/DotNetSessions/tree/main/Day35/SplitingString">Lab - Using Attributes</a></li>
  //  </ol>