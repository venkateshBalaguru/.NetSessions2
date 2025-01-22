using System.Reflection.Metadata.Ecma335;

namespace OutputArrayModify2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] inputArray = { "venkat", "Sachin", "Jaya" };
            string[] outputArray = AddBorder(inputArray);

            foreach (string str in outputArray)
            {
                Console.Write(str);
            }
        }
        public static string[] AddBorder(string[] inputArray)
            {
                string startBorder = "****";
                string endBorder = ",****";
                string[] resultArray = new string[inputArray.Length + 2];

                resultArray[0] = startBorder;


                for (int index = 0; index < inputArray.Length; index++)
                {
                    resultArray[index+1] = ",**" + inputArray[index] + "**";
                }

                //resultArray[resultArray.Length - 1] = endBorder;

                return resultArray;
            }

            
        }

    }