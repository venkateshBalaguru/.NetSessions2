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
        protected double _netSalary;
        protected double _hra;
        protected double _travelAllowance;
        //protected double _performanceAllowance;
        protected double _cTc;
        protected const int MONTH = 12;
        public Employee(int empId, string empName, double basicSalary)
        {
            _empId = empId;
            _empName = empName;
            _basicSalary = basicSalary;
        }

        public int EmpId { get { return _empId; } }
        public string EmpName { get { return _empName; } }

        public double NetSalary {  get { return _netSalary; } }

        //public double PerformanceAllowance {  get { return _performanceAllowance; } }

        public double HRA { get { return _hra; } }

        public double TravelAllowance { get { return _travelAllowance; } }

        public double CTC { get { return _cTc; } }



        public abstract void BasicSalary(double salary);

        
    }
}
