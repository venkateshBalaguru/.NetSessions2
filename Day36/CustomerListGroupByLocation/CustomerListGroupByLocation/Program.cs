using CustomerListGroupByLocation.Models;
using System;
using System.Diagnostics;

namespace CustomerListGroupByLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerList = new List<Customer>();
            customerList.Add(new Customer { Id = 1, Name = "Venkatesh", Location = "Madurai" } );
            customerList.Add(new Customer { Id = 2, Name = "Sachin", Location = "Chennai" });
            customerList.Add(new Customer { Id = 3, Name = "Akhilesh", Location = "Chennai" });
            customerList.Add(new Customer { Id = 4, Name = "Prem", Location = "Chennai" });
            customerList.Add(new Customer { Id = 5, Name = "Raja", Location = "Madurai" });
            customerList.Add(new Customer { Id = 6, Name = "SachinH", Location = "Delhi" });
            var customerListDic = Customer.CustomerGroupByLocation(customerList);
            //PrintDetails(customerListDic);
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }
        }
        //public static void PrintDetails(Dictionary<string, Customer> customers)
        //{
        //    foreach(Dictionary<string,Customer> customer in customers)
        //    {
        //        Console.WriteLine();
        //    }
        //}
    }
}
