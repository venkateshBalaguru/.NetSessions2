using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntityCommonLib.Interfaces;

namespace CollegeEntityCommonLib.Models
{
   
    public class Professor : Person, ISalaried
    {
        public double Salary { get; set; }
        public double Allowance { get; set; }

        public double Deduction { get; set; }
        public Professor(int id, string name, DateOnly dob,  double salary) : base(id,name,dob)
        {

            Salary = salary;
            
        }

        public double CalculateSalary()
        {
            double deduction = Salary * .05;
            Deduction = deduction;
            double allowance = Salary * 0.09;
            Allowance = allowance;
            return Salary+allowance-deduction;
        }

        public override string ToString()
        {
            return base.ToString() + $" || BaseSalary : {this.Salary}  ==> Gross Pay : {CalculateSalary()}";
        }
    }
}
