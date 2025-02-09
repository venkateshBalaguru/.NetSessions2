using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntityCommonLib.Enum;
using CollegeEntityCommonLib.Models;

namespace CollegeEntityCommonLib.PersonServices
{
    public class StudentService
    {
        List<Student> students = new List<Student>();
        
        public void AddStudents(Student nStudent)
        {
            students.Add(nStudent);
        }
        public List<Student> DisplayStudents()
        {
            var stu=new List<Student>();
            foreach (var student in students)
            {
                stu.Add(student);
            }
            return stu;
        }
    }
}
