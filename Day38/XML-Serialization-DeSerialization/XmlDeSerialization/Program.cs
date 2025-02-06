using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml.Serialization;
using XmlSerializationDeserializationCommonLib.Models;

namespace XmlDeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer deSerializer = new XmlSerializer(typeof(Customer));
            FileStream file = new FileStream(@"C:\venkat-html-app\DotNetSessions\Day38\XML-Serialization-DeSerialization\Cus1.xml", FileMode.Open);
            var sr = new StreamReader(file);
            string xmlContent = sr.ReadToEnd();
            var stringReader = new StringReader(xmlContent) ;
            Customer deserializeCus = (Customer)deSerializer.Deserialize(stringReader);
            Console.WriteLine("After Deserialized :");
            Console.WriteLine($"ID : {deserializeCus.Id}| Name : {deserializeCus.Name} | Addressess : {deserializeCus.Addresses.Count}");
            Console.WriteLine("Addressess:");

            foreach (var item in deserializeCus.Addresses)
                {
                    Console.WriteLine($"City : {item.City} | Country : {item.Country} ");
                }
            }
        }
    }

  


