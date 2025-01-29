using System.Security.Cryptography.X509Certificates;

namespace RotateElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 20, 30, 40, 50 };
            //Getting Input from User
            Console.Write("How Many time you want to Rotate the elements : ");
            int userNoToRotate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore Rotating the Elements\n============================");
           //printing the Original array
            Print(inputArray);
           //Rotating the elements
            for (int j = 0; j < userNoToRotate; j++)
            {
                int temp = inputArray[0];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i != 0)
                    {
                        inputArray[i - 1] = inputArray[i];
                    }
                }
                inputArray[inputArray.Length - 1] = temp;
            }
            Console.WriteLine("\nAfter Rotating the Elements " + userNoToRotate + " time\n====================================");
            Print(inputArray);

        }
        public static void Print(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
