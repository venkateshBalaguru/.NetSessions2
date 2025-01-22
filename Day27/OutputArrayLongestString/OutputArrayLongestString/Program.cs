using System;
using System.Diagnostics.CodeAnalysis;

namespace OutputArrayLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Longest Name in the Array\n");
            string[] names = { "Venkat", "Akhilesh", "Raja", "Shalini", "BalaVenk" };
            Console.WriteLine("The Given Names");
            Console.WriteLine("================");
            foreach(string name in names)
            {  Console.WriteLine(name); }
            string[] OutputArray = LongestName(names);
            Console.WriteLine("\nThe Longest Names are:");
            Console.WriteLine("=======================");
            foreach (string name in OutputArray)
            {
                if(name != null)
                Console.WriteLine(name);
            }
  
        }

        public static string[] LongestName(string[] namesArray)
        {
            string[] resultArray = new string[namesArray.Length];

            int HighestnameLength = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i].Length >= HighestnameLength)
                {
                    HighestnameLength = namesArray[i].Length;
                }
            }

            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i].Length == HighestnameLength)
                {
                    resultArray[i] = namesArray[i];
                    
                }
            }
            return resultArray;
        }
    }
}



//using System;

//namespace OutputArrayLongestString
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Finding the Longest Name in the Array");
//            string[] names = { "Venkat", "Akhilesh", "Raja", "Shalini", "BalaVenkatesh" };
//            LongestName(names);
//        }

//        public static void LongestName(string[] namesArray)
//        {
//            string[] resultArray = new string[namesArray.Length];
//            int nameLength = 0;
//            int index = 0;

//            for (int i = 0; i < namesArray.Length; i++)
//            {
//                if (namesArray[i].Length > nameLength)
//                {
//                    nameLength = namesArray[i].Length;
//                    index = i;
//                }
//            }
//            resultArray[0] = namesArray[index];
//            Console.WriteLine(resultArray[0]);

//        }
//    }
//}
