using GenericNodeApp.Models;

namespace GenericNodeApp
{
    internal class Program
    {
         static void Main(string[] args)
            {
                Node<Employee> firstEmployee = new Node<Employee>(new Employee("Venkatesh", 1));
                var secondEmployee = new Node<Employee>(new Employee("Sachin", 2));
                var thirdEmployee  = new Node<Employee>(new Employee("Prem", 3));
                var fourthEmployee = new Node<Employee>(new Employee("Akhilesh", 4));
                var fifthEmployee  = new Node<Employee>(new Employee("SachinH", 5));

                firstEmployee.Next = secondEmployee;
                secondEmployee.Next = thirdEmployee;
                thirdEmployee.Next = fourthEmployee;
                fourthEmployee.Next = fifthEmployee;

                Node<Employee> current = firstEmployee;

                while (current != null)
                {
                    Console.Write($"Employee ID: {current.Data.Id}, Name: {current.Data.Name}");

                    if (current.Next != null)
                    {
                        Console.Write($" -> Next Employee ID: {current.Next.Data.Id}, Name: {current.Next.Data.Name}");
                    }
                    Console.WriteLine();

                    current = current.Next;
                }
            }

        }
    }