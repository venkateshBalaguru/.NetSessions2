


using GenericDictionaryApp.Model;

namespace GenericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            //CaseStudy3();

        }

        private static void CaseStudy3()
        {
            var map = new Dictionary<Customer, Customer>();
            var c1 = new Customer { Id = 1, Name = "Sachin" };
            var c2 = new Customer { Id = 1, Name = "Sachin" };
            var c3 = new Customer { Id = 2, Name = "Deepa" };

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());

            map.Add(c1, c1);
            //map.Add(c2, c2);
            map.Add(c3, c3);
            Console.WriteLine(map.Count);
        }

        private static void CaseStudy2()
        {
            string[] locations = { "chennai", "mumbai", "delhi", "kerala", "kerala", "chennai", "chennai" };
            var map = new Dictionary<string, int>();
            foreach (string location in locations)
            {
                if (!map.ContainsKey(location))
                   map[location] = 1;
                else
                    map[location]++;
            }
            foreach (var key in map.Keys)
            {
                Console.Write(key + ": ");// we get the Key values
                Console.WriteLine(map[key]); // we get the values
            }
        }

        private static void CaseStudy1()
        {
            var map = new Dictionary<string, string> ();
            map.Add("MH", "Maharashtra");
            map.Add("KL", "Kerala");
            map.Add("TN", "TamilNadu");
            map.Add("DL", "Delhi");

            map.Add("DL", "Delhi"); //This will not add because Dictionalry is Unique v

            //foreach (var map in stateCodeMap)
            //{
            //    Console.WriteLine(map.Key);// we get the Key values
            //    Console.WriteLine(map.Value); // we get the values
            //}

            foreach (var key in map.Keys)
            {
                Console.Write(key + ": ");// we get the Key values
                Console.WriteLine(map[key]); // we get the values
            }

            Console.WriteLine(map["TN"].ToUpper());


            if (map.ContainsKey("KL"))
            {
                map["KL"] = "New-Kerala";
                Console.WriteLine(map["KL"]);
            }

        }
    }
}
