using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodandLINQ.Models;

namespace ExtensionMethodandLINQ.Extensions
{
    internal static class AppExtensionMethod
    {
        public static string HelloRRD(this string input)
        {

            return $"Hello {input} , RRD welcomes you !!,how do you do";
        }

        public static void PrintAccountDetails(this Account input)
        {

            Console.WriteLine("Printing deails of account");
            Console.WriteLine(input.Name);
        }
    }
}