using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new file
            FileInfo file = new FileInfo(@"C:\venkat-html-app\DotNetSessions\Day32\StreamWriterFileStreamApp\Output.txt");

            //Inserting the input from user to the file
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("File Created\n===========");
                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine();
                sw.WriteLine(name);
                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();
                sw.WriteLine(address);
            }

        }
    }
}