using System.Globalization;
using System.Linq;
using EmployeeStreamReader.Models;

namespace EmployeeStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\venkat-html-app\\DotNetSessions\\Day46\\EmployeeStreamReader\\Employee.csv";
            char charToTrim = '\'';
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
                        empData.Add(new Employee(empId, values[i + 1], values[i + 2], values[i+3], values[i + 4], values[i + 5], values[i + 6], values[i+7]));
                    }
                }
                sr.Close();
            }

            //Printing the employees Details from the file with only Unique datas
            Console.WriteLine("Details of the Employees\n==========================");
            foreach (var value in empData)
            {
                Console.WriteLine($"EmpId : {value.Id} | EmpName : {value.Name.Trim(charToTrim)} | Desigination : {value.Desigination.Trim(charToTrim)} | MGRId : {value.MgrID.Trim(charToTrim)} | DOJ : {value.Doj.Trim(charToTrim)} | EmpSalary : {value.Salary.Trim(charToTrim)} | Commission : {value.Commission.Trim(charToTrim)} | DeptNo : {value.DeptNo.Trim(charToTrim)}");
            }
            FindEmpName(empData);
            EmpMgrId(empData);
            DeptNo(empData);
            //getting the method value in to variable
            //var employee = empGroupByDesg(empData);
            //PrintDetails(employee);
        }
        //Grouping the Emp Data with the Desigination
        //public static Dictionary<string, List<Employee>> empGroupByDesg(HashSet<Employee> empData)
        //{
        //    var map = new Dictionary<string, List<Employee>>();
        //    foreach (Employee emp in empData)
        //    {
        //        if (!map.ContainsKey(emp.Desigination))
        //            //groupByLocation[customer.Location] = new List<Customer>();//we can do like this also 
        //            map.Add(emp.Desigination, new List<Employee>());
        //        map[emp.Desigination].Add(emp);
        //    }
        //    return map;
        //}

        //public static void PrintDetails(Dictionary<string, List<Employee>> employees)
        //{
        //    char charToTrim = '\''; //Triming the unwanted characters
        //    Console.WriteLine($"\nGrouping By Desigination:\n===========================");
        //    foreach (var employee in employees)
        //    {
        //        Console.WriteLine($"\n{employee.Key.Trim(charToTrim)}\n-------------------");
        //        foreach (var emp in employee.Value)
        //        {
        //            Console.WriteLine($"ID : {emp.Id} || Name : {emp.Name.Trim(charToTrim)}");
        //        }
        //    }
        //}
        private static void FindEmpName(HashSet<Employee> empData)
        {
            var employee = empData.Single(x => x.Name == "'KING'");
            Console.WriteLine("\nselect employee Name is King\n==============================\n");
            Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.MgrID} | {employee.Desigination} ");
        }

        private static void DeptNo(HashSet<Employee> empData)
        {
            var DeptList = empData.Where(e => e.DeptNo.Contains("10")).AsEnumerable();
            var enumerator = DeptList.GetEnumerator();
            Console.WriteLine("\nSelect Dept where dept Id=10\n===============================\n");
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.MgrID} | {employee.Desigination} |{employee.DeptNo}");
            }
        }

        private static void EmpMgrId(HashSet<Employee> empData)
        {
            Console.WriteLine("\nSelect Manager from list\n===========================\n");
            var ManagerIdList = empData.Where(e => e.Desigination.Contains("MANAGER")).AsEnumerable();
            var enumerator = ManagerIdList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.MgrID} | {employee.Desigination} ");
            }

        }
    }
}

   
