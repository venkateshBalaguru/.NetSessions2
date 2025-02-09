using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntityCommonLib.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DOB { get; set; }

        public Person(int id, string name, DateOnly dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }
        public override string ToString()
        {
            return $"Id : {this.Id} || Name : {this.Name} || DOB : {this.DOB.ToString("yyyy-MM-dd")}";
        }
    }
    

}
