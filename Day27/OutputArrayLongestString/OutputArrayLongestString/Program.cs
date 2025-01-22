using System;
using System.Diagnostics.CodeAnalysis;

namespace OutputArrayLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Longest Name in the Array");
            string[] names = { "Venkat", "Akhilesh", "Raja", "Shalini", "BalaVenk" };
            string[] OutputArray = LongestName(names);
            foreach (string name in OutputArray)
            {
                Console.WriteLine(name);
            }
  
        }

        public static string[] LongestName(string[] namesArray)
        {
            string[] resultArray = new string[];

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
                    //Console.WriteLine(resultArray[i]);
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
