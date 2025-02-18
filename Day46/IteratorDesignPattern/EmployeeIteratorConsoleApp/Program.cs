// See https://aka.ms/new-console-template for more information
using EmployeeIteratorCommonLib.Models;

EmployeeCollection collection = new EmployeeCollection();
collection.AddEmployee(new Employee("Venkatesh", 100571));
collection.AddEmployee(new Employee("Balaguru", 100081));
collection.AddEmployee(new Employee("Akhilesh", 105478));
collection.AddEmployee(new Employee("Sachin", 104873));
collection.AddEmployee(new Employee("Prem", 104584));

Iterator iterator = collection.CreateIterator();
   
Console.WriteLine("Iterating over collection:\n=========================\n");

for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"Employee ID : {emp.ID} ==> Employee Name : {emp.Name}");
}
          