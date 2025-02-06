using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using XmlSerialization;
using System.Xml.Serialization;
using XmlSerializationDeserializationCommonLib.Models;

namespace XmlSerialization
{
    internal class Program
    {
        private static readonly Stream fs;

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
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            using (var xmlWriter = new StringWriter())
            {
                serializer.Serialize(xmlWriter, c1);
                string xml = xmlWriter.ToString();
                //Console.WriteLine(xml);
                var sw = new StreamWriter(@"C:\venkat-html-app\DotNetSessions\Day38\XML-Serialization-DeSerialization\Cus1.xml");
                sw.WriteLine(xml);
                sw.Close();
                Console.WriteLine("Written to File...");
            }
        }
    }
}

