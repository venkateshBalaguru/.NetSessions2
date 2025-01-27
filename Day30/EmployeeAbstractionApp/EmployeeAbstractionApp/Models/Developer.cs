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
        private double _netSalary;
        private double _cTc;
        public Developer(int empId, string empName, double basicSalary) : base(empId, empName, basicSalary) { }

        public override string GetDetails()
        {
            _performanceAllowance = _basicSalary * .40;
            return $" Performance Allowance : {_performanceAllowance} ||";
        }
        public override double NetSalary()
        {
            _netSalary = _performanceAllowance + _basicSalary;
            return _netSalary;
        }

        public override double CTC()
        {
            _cTc = _netSalary * 12;
            return _cTc;
        }


    }
}
