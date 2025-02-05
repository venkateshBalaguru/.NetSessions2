using System.Text.Json;
using CustomerCommonLib.Models;
namespace SerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeToJson();
        }
        public static void SerializeToJson()
        {
            var c1 = new Customer
            {
                Id = 1,
                Name = "Venkatesh",
                Addresses = new List<Address> {
                new Address{ City="Madurai",Country="India"},
                new Address{ City="Chennai",Country="India" } }
            };
            var jsonString = JsonSerializer.Serialize(c1);
            Console.WriteLine(jsonString);
            var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\Serialization_DeSerialization\Cus1.json");
            sw.WriteLine(jsonString);
            sw.Close();
            Console.WriteLine("Written to File...");
        }
    }
}
