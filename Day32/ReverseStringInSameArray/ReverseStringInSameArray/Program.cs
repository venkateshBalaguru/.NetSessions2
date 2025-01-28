namespace ReverseStringInSameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Venkat", "Akhilesh", "Sachin" };

          for (int i = inputArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(inputArray[i]);
            }

        }
    }
}
