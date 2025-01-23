using System;   
using System.Security.Cryptography.X509Certificates;

namespace AlphabetSequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "az","baca", "ad","AB","Aba" };
            Console.WriteLine("Finding the given names IsCorrect alphabet sequence");
            Console.WriteLine("===================================================");

            SequenceAlphabet(names);
        }


        public static void SequenceAlphabet(string[] names)
        {

            foreach (string name in names)
            {
                string lowerCaseName = name.ToLower();
                Console.WriteLine($"The Given Name {name} IsSequence==> {IsSequence(lowerCaseName)}");
            }
        }
        public static bool IsSequence(string name)
        {
            int checkAlpha = 0;
            foreach (char c in name)
            {
                if (c >= checkAlpha)
                {
                    checkAlpha = c;
                }
                else { return false; }
                
            }
            return true;
        }

    }
}