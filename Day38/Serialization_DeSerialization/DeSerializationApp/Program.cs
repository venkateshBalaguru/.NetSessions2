using System.Runtime.Loader;
using System.Text.Json;
using CustomerCommonLib.Models;

namespace DeSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\venkat-html-app\DotNetSessions\Day38\Serialization_DeSerialization\Cus1.json");
            var jsonString = sr.ReadToEnd();
            //Console.WriteLine(jsonString);
            //Deserialization will create a new object without using new keyword it will happen in background but the fields must be public otherwise it will throw error
            var customer = JsonSerializer.Deserialize<Customer>(jsonString);
            Console.WriteLine("After Deserialized :");
            Console.WriteLine($"ID : {customer.Id} | Name : {customer.Name} | Addressess : {customer.Addresses.Count}");
            Console.WriteLine("Addressess:");
            foreach (var item in customer.Addresses)
            {
                Console.WriteLine($"City : {item.City} | Country : {item.Country} ");
            }
        }
    }
}
