using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace SumOfAlternateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 10, 10, 10, 10, 10, 10 };

            CaseStudy1(inputArray);
            CaseStudy2(inputArray);

        }

        static void CaseStudy2(int[] inputArray)
        {
            int[] OutputArray = SumOfOddEvenNumbers(inputArray);
            Console.WriteLine("\nSum of Alternate numbers:");
            foreach (int i in OutputArray)
            {
               Console.WriteLine(i);
            }
        }

        static int[] SumOfOddEvenNumbers(int[] inputArray)
        {
            int even = 0;
            int odd = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += inputArray[i];
                }
                else
                {
                    odd += inputArray[i];
                }
            }
            return new int[] { even, odd};

        }


            static void CaseStudy1(int[] inputArray) 
            {
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
            Console.WriteLine("Sum of Alternate numbers:\n");
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

