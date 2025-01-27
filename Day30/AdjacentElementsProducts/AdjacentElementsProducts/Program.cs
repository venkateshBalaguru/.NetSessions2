//using System;
//namespace AdjacentElementsProducts
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] adjElements = { 15,15,5, 2, 4, 7, 3,12,12 };
//            int[] outputArray = new int[adjElements.Length - 1];
//            int adjacentProduct = 1;
//            int highestProduct = 0;
//            //int low = 0;

//            for (int i = 0; i < adjElements.Length - 1; i++)
//            {
//                if (adjElements[i] > adjElements[i + 1])
//                {
//                    outputArray[i] = adjElements[i] - adjElements[i + 1];

//                }
//                else
//                {
//                    outputArray[i] = adjElements[i + 1] - adjElements[i];

//                }
//                Console.WriteLine($"Adjacent Number Difference :{outputArray[i]}");
//            }
//            int low = outputArray[0];
//            foreach (int output in outputArray)
//            {
//                if (low > output)
//                {
//                    low = output;
//                }
//            }
//            Console.WriteLine($"\nNumber of lowest difference : {low}");


//            for (int i = 0; i < adjElements.Length - 1; i++)
//            {
//                if (adjElements[i] > adjElements[i + 1])
//                {
//                    outputArray[i] = adjElements[i] - adjElements[i + 1];
//                }
//                else
//                {
//                    outputArray[i] = adjElements[i + 1] - adjElements[i];
//                }
//                if (low == outputArray[i])
//                {
//                    adjacentProduct = adjElements[i] * adjElements[i + 1];
//                    if (highestProduct < adjacentProduct)
//                    {
//                        highestProduct = adjacentProduct;
//                    }

//                }
//            }
//            Console.WriteLine($"\nHighest Product of Lowest Difference between Adjacent Numbers : {highestProduct}");

//        }

//    }
//}

using System;
namespace AdjacentElementsProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] adjElements = { 15, 15, 5, 2, 4, 7, 3, 12, 12 };
            int[] outputArray = new int[adjElements.Length - 1];
            int adjacentProduct = 1;
            int highestProduct = 0;
            //int low = 0;

            for (int i = 0; i < adjElements.Length - 1; i++)
            {
                if (adjElements[i] > adjElements[i + 1])
                {
                    outputArray[i] = adjElements[i] - adjElements[i + 1];

                }
                else
                {
                    outputArray[i] = adjElements[i + 1] - adjElements[i];

                }
                Console.WriteLine($"Adjacent Number Difference :{outputArray[i]}");
            }
            int low = outputArray[0];
            foreach (int output in outputArray)
            {
                if (low > output)
                {
                    low = output;
                }
            }
            Console.WriteLine($"\nNumber of lowest difference : {low}");


            for (int i = 0; i < adjElements.Length - 1; i++)
            {
                if (adjElements[i] > adjElements[i + 1])
                {
                    outputArray[i] = adjElements[i] - adjElements[i + 1];
                }
                else
                {
                    outputArray[i] = adjElements[i + 1] - adjElements[i];
                }
                if (low == outputArray[i])
                {
                    adjacentProduct = adjElements[i] * adjElements[i + 1];
                    if (highestProduct < adjacentProduct)
                    {
                        highestProduct = adjacentProduct;
                    }

                }
            }
            Console.WriteLine($"\nHighest Product of Lowest Difference between Adjacent Numbers : {highestProduct}");

        }

    }
}



