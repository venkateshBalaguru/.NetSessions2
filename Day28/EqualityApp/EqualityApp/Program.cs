﻿using System;
using EqualityApp.Models;

namespace EqualityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseSTudy2();
        }
        private static void CaseSTudy2()
        {

            var venakt1 = new Employee(1, "Venkat", 1000);
            var venakt2 = new Employee(1, "Venkat", 3000);

            Console.WriteLine(venakt1 == venakt2);//Referential equality

            var venakt3 = venakt1;
            Console.WriteLine(venakt3 == venakt1);

            //value based equality
            Console.WriteLine(venakt1.Equals(venakt2));


        }
        public static void CaseStudy1()
        {
            var emp = new Employee(1,"Venkat",30000);
            Console.WriteLine(emp);
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.GetType());

        }
    }
}
