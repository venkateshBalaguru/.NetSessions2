using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlphaSequenceApp2.Models
{
    class Sequence
    {
        public static void SequenceAlphabet(string[] names)
        {

            foreach (var name in names)
            {
                string lowerCaseName = name.ToLower();
                Console.WriteLine($"The Given Name {name} IsSequence==> {IsSequence(lowerCaseName)}");
            }
            
        }
         

        private static bool IsSequence(string name)
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

