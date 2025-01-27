using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityApp.Models
{
    class Employee
    {
        private readonly int _id;
        private readonly string _name;
        public readonly double _salary;

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int Id
        {
            get { return _id; }

        }

        public string Name
        {
            get { return _name; }

        }
        public double Salary
        {
            get { return _salary; }

        }

        public override string ToString()
        {
            return $" Id ==> {_id} , Name ==> {_name} , Salary {_salary} , base implement : {base.ToString()}";
        }
        //This Equals method is from Object class we have to override for our logic
        public override bool Equals(Object obj)
        {

            var second = (Employee)obj;
            
            return this._id == second._id && this._name == second._name;
        }
        //This Equals method is created in our Employee Class. if we created this our method only execute eventhought the parent method will not execute
        //public bool Equals(Employee obj)
        //{
        //    var second = obj;
        //    return this._id != second._id && this._name != second._name;
        //}

    }
}