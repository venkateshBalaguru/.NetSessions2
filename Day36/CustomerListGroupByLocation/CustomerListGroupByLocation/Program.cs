using CustomerListGroupByLocation.Models;
using System;
using System.Diagnostics;
using System.Net.WebSockets;

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

            //foreach (Customer customer in customerList)
            //{
            //    Console.WriteLine(customer);
            //}

            var customers = CustomerGroupByLocation(customerList);
            PrintDetails(customers);
        }
        public static Dictionary<string, List<Customer>> CustomerGroupByLocation(List<Customer> customersList)
        {
            var groupByLocation = new Dictionary<string, List<Customer>>();
            foreach (Customer customer in customersList)
            {
                if (!groupByLocation.ContainsKey(customer.Location))
                    //groupByLocation[customer.Location] = new List<Customer>();//we can do like this also 
                    groupByLocation.Add(customer.Location, new List<Customer>());
                groupByLocation[customer.Location].Add(customer);
            }
                    
            return groupByLocation;
        }

        public static void PrintDetails(Dictionary<string, List<Customer>> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Key);
                foreach(var cus in customer.Value)
                {
                    Console.WriteLine($"ID : {cus.Id} || Name : {cus.Name}");
                }
            }
        }
            
        }

    }

