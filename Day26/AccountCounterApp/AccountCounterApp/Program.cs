using System;
using AccountCounterApp.Models;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //static prorperty
            Console.ForegroundColor = ConsoleColor.Red;

            var venkat = new Account(101, "Venakat", 2000);
            Console.WriteLine("instance counter" + venkat.InstanceCounter);
            Console.WriteLine("Head count - " + Account.HeadCount);

            Console.ResetColor();//staic method


            var minu = new Account(102, "Minu", 1000);
            Console.WriteLine("instance counter" + venkat.InstanceCounter);
            Console.WriteLine("Head count - " + Account.HeadCount);

            new Account(103, "Akhilesh", 3000);
            Console.WriteLine("instance counter" + minu.InstanceCounter);
            Console.WriteLine("Head count - " + Account.HeadCount);


            Console.WriteLine("Head count - " + Account.HeadCount);
            Console.WriteLine("instance counter" + venkat.InstanceCounter);
        }
    }
}