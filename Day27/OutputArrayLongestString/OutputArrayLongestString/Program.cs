using System;

namespace OutputArrayLongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the Longest Name in the Array");
            String[] names = { "Venkat", "Akhilesh", "Raja", "Shalini", "BalaVenk" };
            LongestName(names);
        }

        public static string[] LongestName(string[] namesArray)
        {
            string[] resultArray = new string[namesArray.Length];
            int nameLength = 0;
            int index = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i].Length > nameLength)
                {
                    nameLength = namesArray[i].Length;
                    index = i;
                }
            }
            resultArray[1] = namesArray[index];
            Console.WriteLine(resultArray[1]);
            return resultArray;
        }
    }
}
