using System.Text.Json;
using CommonLib.Models;
namespace Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\venkat-html-app\DotNetSessions\Day38\DeSerialization\Cust1.json");
            var data = sr.ReadToEnd();
            //Console.WriteLine(data);
            var customer  = JsonSerializer.Deserialize<Customer>(data);
            Console.WriteLine("After Deserialized :");
            Console.WriteLine($"ID : {customer.Id} | Name : {customer.Name} | Addressess : {customer.Addresses.Count}");
            for (int i = 0; i < customer.Addresses.Count; i++)
            {
                Console.Write($"Address: {i+1} ==>");
                Console.WriteLine($"City : {customer.Addresses[i].City} | Country : {customer.Addresses[i].Country}");
            }
        }
    }
}
