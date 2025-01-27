using System.ComponentModel.Design;

namespace SumOfAlternateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = {10,10,10,10,10,10,10};
            int[] outputArray = new int[2];
            int numberCount = inputArray.Length / 2;

            if (numberCount % 2 == 0)
            {
                SumAlternateNumbers(inputArray, outputArray, numberCount);
            }
            else
            {
                SumAlternateNumbers(inputArray, outputArray, numberCount);
                outputArray[0] += inputArray[inputArray.Length - 1];
            }
            Console.WriteLine(outputArray[0]);
            Console.WriteLine(outputArray[1]);
        }
        public static void SumAlternateNumbers(int[] inputArray, int[] outputArray, int numberCount)
        {
            int j = 0;
            for (int i = 0; i < numberCount; i++)
            {
               outputArray[0] += inputArray[j];
               outputArray[1] += inputArray[j + 1];
               j = j + 2;
             }

         }


        }
    }

