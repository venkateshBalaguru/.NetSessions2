using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStreamReader.Models
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _desigination;

        public Employee(int id, string name, string desigination) 
        {
            _id = id;
            _name = name;
            _desigination = desigination;

        }
        public int Id{get { return _id; }}
        public string Name { get { return _name; } }
        public string Desigination {  get { return _desigination; } }


        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object other)
    {
        Employee second = (Employee)other;
        if (this.Id == second.Id )
        {
            return true;
        }
        return false;
    }
    //public override string ToString()
    //{
    //    return $"id is  {this.Id} , name is {this.Name} , desigination is {this.Desigination}";
    //}
}
}
