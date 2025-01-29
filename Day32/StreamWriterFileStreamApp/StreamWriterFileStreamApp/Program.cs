

namespace ReverseStringInSameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Venkat", "Akhilesh", "Sachin","Raja" };
            Console.WriteLine("Array in Reverse order\n");
            int i = inputArray.Length-1;
            foreach(string input in inputArray)
            {
                    inputArray[i] = input;
                    Console.WriteLine(inputArray[i]);
                i--;

            }

            //Console.WriteLine();
            //foreach (string input in inputArray)

            //    Console.WriteLine(input);
        }
    }
}



//namespace ArraySortingApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Create string array
//            string[] array = { "orange", "markonda", "banana", "grape" };

//            Console.WriteLine("Print reverse string same array");
//            for (int i = array.Length - 1; i >= 0; i--)
//            {
//                Console.WriteLine(array[i]);
//            }
//            Console.WriteLine("");

//            //Print before sorting
//            Console.WriteLine("Before sorting:");
//            PrintArray(array);

//            //Sort the array elements
//            BubbleSort(array);

//            //Print after softing
//            Console.WriteLine("After sorting:");
//            PrintArray(array);
//        }

//        private static void PrintArray(string[] array)
//        {
//            foreach (var item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }

//        private static void BubbleSort(string[] array)
//        {
//            int n = array.Length;
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (!CompareFirstCharacter(array[j], array[j + 1]))
//                    {
//                        // Swap elements
//                        string temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;
//                    }
//                }
//            }
//        }


//namespace CodingExcercise_ReverseArray
//  {
//      internal class Program
//      {
//          static void Main(string[] args)
//          {
//              string[] array = { "abc", "pqr", "xyz","raja" };

//              int startIndex = 0; int endIndex = array.Length - 1;

//              ArrayElementinReverseOrder(array, startIndex, endIndex);

//              Console.WriteLine("Array In reverse order ->");
//              for (int i = 0; i < array.Length; i++)
//              {
//                  Console.WriteLine(array[i]);
//              }
//          foreach (string name in array)
//          {
//              Console.WriteLine(name);
//          }
//      }


//          private static void ArrayElementinReverseOrder(string[] array, int startIndex, int endIndex)
//          {
//              while (startIndex < endIndex)
//              {
//                  string tempStratIndex = array[startIndex];
//                  array[startIndex] = array[endIndex];
//                  array[endIndex] = tempStratIndex;
//                  startIndex++;
//                  endIndex--;
//              }
//          }
//      }
//  }

