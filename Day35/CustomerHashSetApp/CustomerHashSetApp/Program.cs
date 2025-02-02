﻿using System.Net.NetworkInformation;
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
