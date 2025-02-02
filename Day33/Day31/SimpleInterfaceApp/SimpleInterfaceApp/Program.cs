using SimpleInterfaceApp.Models;
namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ICrudable x; // x expects an object of a class which implements the interface

            DoDBOperation(new CustomerRepository());
            DoDBOperation(new CountryRepository());
            DoDBOperation(new ProductRepository());
        }

        public static void DoDBOperation(ICrudable crudable)  // IsA, Polymorphic
        {
            Console.WriteLine("Doing DB operations");
            crudable.Create();
            crudable.Read();
            crudable.Update(); 
            crudable.Delete();
            Console.WriteLine("Completed the DB operations");
            Console.WriteLine();
        }
    }
}
