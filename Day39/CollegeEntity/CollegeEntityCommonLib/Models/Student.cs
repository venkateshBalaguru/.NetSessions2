using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntityCommonLib.PersonServices;
using CollegeEntityCommonLib.Enum;
using CollegeEntityCommonLib.Interfaces;

namespace CollegeEntityCommonLib.Models
{
    public class Student : Person
    {
        private Branch _department; 

        public Student(int id, string name, DateOnly dob, Branch department) : base(id, name, dob)
        {
            _department = department;
        }
        public Branch Deptartment
        {
            get { return _department; }
        }
        public override string ToString()
        {
            return base.ToString() + $"Department : {this.Deptartment}";
        }
    }
}
