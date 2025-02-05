using System.Text.Json;
using XmlSerialization;
using XmlSerializationDeserializationCommonLib.Models;

namespace XmlSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeToXML();
        }
        public static void SerializeToXML()
        {
            var c1 = new Customer
            {
                Id = 10571,
                Name = "Bala",
                Addresses = new List<Address>
                {
                   new Address { City = "Madurai-Main", Country = "India" },
                   new Address { Country = "India", City = "Madurai-Central"}
                }
            };
            //XmlSerialization.
            //var jsonString = JsonSerializer.Serialize(c1);
            //Console.WriteLine(jsonString);
            //var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\Serialization_DeSerialization\Cus1.json");
            //sw.WriteLine(jsonString);
            //sw.Close();
            //Console.WriteLine("Written to File...");
        }
    }
}
