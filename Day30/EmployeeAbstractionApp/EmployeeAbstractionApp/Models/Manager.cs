using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstractionApp.Models
{
     class Manager : Employee
    {
        public Manager(int  empId, string empName, double basicSalary) : base(empId, empName, basicSalary) 
        {
        }

        public override void BasicSalary(double salary)
        {
            _hra = (50 / _basicSalary) * 100;
            _travelAllowance = (60 / _basicSalary) * 100;
            _netSalary = _basicSalary + _hra + _travelAllowance;
            _cTc = _netSalary * 12;
        }
    }
}
