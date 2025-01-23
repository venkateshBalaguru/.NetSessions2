namespace NextLetterAlphaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Raja","venkat", "Jaya","Zz" };
            Console.WriteLine("The Names in Correct alphabet order");
            Console.WriteLine("====================================");
            foreach (string name in names)
            {
                
                Console.WriteLine(name);
            }
            Console.WriteLine("\n\nThe Given Names Letter changes to next Letter ");
            Console.WriteLine("==============================================");
            NextLetter(names);
        }


        public static void NextLetter(string[] names)
           {

            foreach (string name in names)
            {
                string nextAlphabet = "";
                foreach (char c in name)
                {
                    if (c != 'z' && c!='Z')
                    {
                        nextAlphabet += (char)(c+1);
                    }
                    else
                        nextAlphabet += (char)(c-25);
                }
            
                Console.WriteLine(nextAlphabet);
            }
            
        }
    
    }
}
