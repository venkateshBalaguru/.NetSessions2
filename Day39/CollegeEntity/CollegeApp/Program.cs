using CollegeEntityCommonLib.Models;
using CollegeEntityCommonLib.Enum;
using CollegeEntityCommonLib.PersonServices;
using System;
using CollegeEntityCommonLib.Interfaces;
using System.Net;
namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudents(new Student(101, "Venkatesh", new DateOnly(2004, 12, 31), Branch.BE));
            studentService.AddStudents(new Student(102, "Balagurunathan", new DateOnly(2004, 12, 24), Branch.BCom));
            studentService.AddStudents(new Student(103, "Sachin", new DateOnly(2005, 04, 10), Branch.BSc));
            //PrintDetails(studentService);
            var studentfromstu = studentService.DisplayStudents();
            PrintDetails(studentfromstu);

            var professorService = new ProfessorService();
            professorService.AddProfessor(new Professor(202, "RajaVenkat", new DateOnly(1985, 12, 3), 70000));
            professorService.AddProfessor(new Professor(203, "Akhilesh", new DateOnly(1988, 12, 3), 50000));
            professorService.AddProfessor(new Professor(204, "Jayapretthi", new DateOnly(1992, 6, 3), 40000));
            PrintDetails(professorService);
        }
        //private static void PrintDetails(StudentService studentService)
        //{
        //    Console.WriteLine("student detials\n====================");
        //    foreach (var student in studentService)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}

        private static void PrintDetails(List<Student> students) 
        {
            Console.WriteLine("Student Detials\n====================");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void PrintDetails(ProfessorService lectures)
        {
            Console.WriteLine("Professors Detials\n====================");
            foreach (var professor in lectures.professors)
            {
                Console.WriteLine(professor);
            }
        }
    }
}
