using System.Globalization;
using System.Linq;
using EmployeeStreamReader.Models;

namespace EmployeeStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day37\\Employee.csv";
            HashSet<Employee> empData = new HashSet<Employee>();  //using HashSet for getting the unique values


            //Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;  //For Ignoring the first line
                //Iterating until null
                while ((line = sr.ReadLine()) != null)
                {
                    //First line caption was removing and inserting the remaining lines
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }
                    string[] values = line.Split(',');
                    for (int i = 0; i < 1; i++)
                    {
                        var empId = Convert.ToInt32(values[i]); 
                        empData.Add(new Employee(empId, values[i + 1], values[i + 2]));
                    }
                }
                sr.Close();
            }

            //Printing the employees Details from the file with only Unique datas
            Console.WriteLine("Details of the Employees\n==========================");
            foreach (var value in empData)
            {
                Console.WriteLine($"EmpId : {value.Id} | EmpName : {value.Name} | EmpDesigination : {value.Desigination}");
            }
            //getting the method value in to variable
            var employee = empGroupByDesg(empData);
            PrintDetails(employee);
        }
        //Grouping the Emp Data with the Desigination
        public static Dictionary<string, List<Employee>> empGroupByDesg(HashSet<Employee> empData)
        {
            var map = new Dictionary<string, List<Employee>>();
            foreach (Employee emp in empData)
            {
                if (!map.ContainsKey(emp.Desigination))
                    //groupByLocation[customer.Location] = new List<Customer>();//we can do like this also 
                    map.Add(emp.Desigination, new List<Employee>());
                map[emp.Desigination].Add(emp);
            }
            return map;
        }

        public static void PrintDetails(Dictionary<string, List<Employee>> employees)
        {
            char charToTrim = '\''; //Triming the unwanted characters
            Console.WriteLine($"\nGrouping By Desigination:\n===========================");
            foreach (var employee in employees)
            {
                Console.WriteLine($"\n{employee.Key.Trim(charToTrim)}\n-------------------");
                foreach (var emp in employee.Value)
                {
                    Console.WriteLine($"ID : {emp.Id} || Name : {emp.Name.Trim(charToTrim)}");
                }
            }
        }
    }
}

   
