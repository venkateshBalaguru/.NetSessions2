using System;
using System.ComponentModel.DataAnnotations.Schema;


using EmployeeAbstractionApp.Models;

namespace EmployeeAbstractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager1 = new Manager(1, "Venkat", 20000);
            //Employee manager2 = new Employee(2, "guru", 30000);
            Employee Developer1 = new Developer(2, "Bala", 25000);

            PrintDetails(manager1);
            PrintDetails(Developer1);
            //PrintDetails(manager2);


        }

        public static void PrintDetails(Employee employee)
        {
            Console.WriteLine($"Employee Name : { employee.EmpName}\n");
            Console.WriteLine($"Employee ID : {employee.EmpId}");
            //Console.WriteLine($"Employee Performance Allowance : {employee.Perfor}")
            Console.WriteLine($"Employee Basic Salary : {employee.BasicSalary} ");
            //Console.WriteLine($"Employee Performance Allowance : {employee.PerformanceAllowance}");
            Console.WriteLine($"Employee Net Pay : {employee.NetSalary}");
            Console.WriteLine($"Employee CTC : {employee.CTC}");
        }
    }
}
