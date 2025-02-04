namespace SplitingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "venkat.Bala", "abc.dfc", "raja.guru", "efg.adf" };
            string[] outputArray = new string[inputArray.Length];
            Console.WriteLine("Before Split String\n=====================");
            PrintDetails(inputArray);

            CaseStudy1(inputArray, outputArray);
            CaseStudy2(inputArray, outputArray);
            CaseStudy3(inputArray, outputArray);
        }
        public static void CaseStudy1(string[] inputArray, string[] outputArray)
        {
            int j = 0;
            foreach (string item in inputArray)
            {
                string[] output = item.Split(".");
                for (int i = 1; i < output.Length; i++)
                {
                    outputArray[j] = output[i];
                    j++;
                }
            }
            Console.WriteLine("\nAfter Split the String using Split Function\n===================================================");
            PrintDetails(outputArray);
        }

        public static void CaseStudy2(string[] inputArray, string[] outputArray)
        {
            int j = 0;
            foreach (string item in inputArray)
            {
                int check = item.IndexOf(".");
                string result = "";
                for (int i = check+1; i < item.Length; i++)
                {
                    result = result + item[i];                 
                }
                outputArray[j] = result;
                j++;
            }
            Console.WriteLine("\nAfter Split the String using indexOf Function\n===================================================");
            PrintDetails(outputArray);


        }
        public static void CaseStudy3(string[] inputArray, string[] outputArray)
        {
            int j = 0;
            foreach (string item in inputArray)
            {
                int dotCharValue = 46;
                string output = "";
    
                for (int i =0 ; i < item.Length; i++)
                {
                   if (item[i] == (char)dotCharValue)
                    {
                        output = "";
                        i++;
                    }
                   output += item[i];   
                }
                outputArray[j] = output;
                j++;
            }
            
            Console.WriteLine("\nAfter Split the String without Inbuild function\n============================================");
            PrintDetails(outputArray);
        }

        public static void PrintDetails(string[] outputArray)
        {
            foreach (string item in outputArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
