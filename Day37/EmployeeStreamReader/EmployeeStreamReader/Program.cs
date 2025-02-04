using System.Globalization;
using EmployeeStreamReader.Models;

namespace EmployeeStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day37\\Employee.csv";
            HashSet<Employee> empData = new HashSet<Employee>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;
                while ((line = sr.ReadLine()) != null)
                {
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
            foreach (var value in empData)
            {
                Console.WriteLine($"EmpId : {value.Id} | EmpName : {value.Name} | EmpDesigination : {value.Desigination}");
            }

            var employee = empGroupByDesg(empData);
            PrintDetails(employee);
        }
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
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key);
                foreach (var emp in employee.Value)
                {
                    Console.WriteLine($"ID : {emp.Id} || Name : {emp.Name}");
                }
            }
        }
    }
}

   
