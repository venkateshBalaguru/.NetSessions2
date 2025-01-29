using System.Security.Cryptography.X509Certificates;

namespace ReverseStringInSameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Venkat", "Akhilesh", "Sachin" };
            string temp;
            int arrayLength = inputArray.Length-1;
            Console.WriteLine("Array in straight order\n======================");
            PrintArray(inputArray);
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                temp = inputArray[i];
                inputArray[i] = inputArray[arrayLength];
                inputArray[arrayLength] = temp;
                arrayLength--;
            }
            Console.WriteLine("\nArray in Reverse Order\n========================");
            PrintArray(inputArray);
        }
        public static void PrintArray(string[] inputArray)
        {
            foreach (string input in inputArray)
            {
                Console.WriteLine(input);
            }
        }
    }
}