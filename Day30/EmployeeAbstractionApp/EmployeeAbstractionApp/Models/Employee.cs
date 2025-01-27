using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstractionApp.Models
{
    abstract class Employee
    {
        private int _empId;
        private string _empName;
        protected double _basicSalary;
        public Employee(int empId, string empName, double basicSalary)
        {
            _empId = empId;
            _empName = empName;
            _basicSalary = basicSalary;

        }

        public int EmpId { get { return _empId; } }
        public string EmpName { get { return _empName; } }

        public double BasicSalary {  get { return _basicSalary; } }   
        
        public abstract string GetDetails();
        public abstract double NetSalary();

        public abstract double CTC();

        
    }
}
