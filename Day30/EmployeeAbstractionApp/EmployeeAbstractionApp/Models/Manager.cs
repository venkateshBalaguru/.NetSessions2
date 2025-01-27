using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstractionApp.Models
{
     class Manager : Employee
    {

        private double _netSalary;
        private double _cTc;
        private double _travelAllowance;
        private double _hra;
        public Manager(int  empId, string empName, double basicSalary) : base(empId, empName, basicSalary) 
        {
        }

        public override string GetDetails()
        {
            _hra = _basicSalary * .40;
            _travelAllowance = _basicSalary * .50;
            return $" HRA : {_hra} || Travel Allowance : {_travelAllowance} ||";
        }
        public override double NetSalary()
        {
            _netSalary = _hra + _travelAllowance + _basicSalary;
            return _netSalary;
        }

        public override double CTC()
        {
            _cTc = _netSalary * 12;
            return _cTc;
        }
    }
}
