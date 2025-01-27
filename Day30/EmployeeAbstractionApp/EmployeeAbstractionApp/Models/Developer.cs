using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstractionApp.Models
{
    class Developer : Employee
    {
        private double _performanceAllowance;
        public Developer(int empId, string empName, double basicSalary) : base(empId, empName, basicSalary) { }

        public double PerformanceAllowance { get { return _performanceAllowance; } }
        public override double BasicSalary(double salary)
        {
            _performanceAllowance = ((40 / _basicSalary) * 100);
            _netSalary = _basicSalary + _performanceAllowance;
            _cTc = _netSalary * MONTH;
        }
    }
}
