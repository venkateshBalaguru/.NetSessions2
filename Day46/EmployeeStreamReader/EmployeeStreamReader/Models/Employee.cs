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
        private string _mgrId;
        private string _doj;
        private string _sal;
        private string _com;
        private string _deptNo;

               

        public Employee(int id, string name, string desigination,string mgrId, string doj, string salary, string commission, string deptno) 
        {
            _id = id;
            _name = name;
            _desigination = desigination;
            _mgrId = mgrId;
            _doj = doj;
            _sal = salary;
            _com = commission;
            _deptNo = deptno;


        }
        public int Id{get { return _id; }}
        public string Name { get { return _name; } }
        public string Desigination {  get { return _desigination; } }

        public string MgrID { get { return _mgrId; }}
        public string Doj { get { return _doj; }}
        public string Salary { get { return _sal; }}
        public string Commission { get { return _com; }}
        public string DeptNo { get { return _deptNo; }}



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
