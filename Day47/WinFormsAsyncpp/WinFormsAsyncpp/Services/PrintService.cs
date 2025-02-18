using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsyncpp.Services
{
    internal class PrintService
    {
        //public void Print() //This will print recursively
        //{
        //    while (true)
        //    {
        //        Debug.WriteLine($"Time is {DateTime.Now.ToString("hh:mm:ss")}");
        //    }
        //}
        public void Print() 
        {
            DateTime startTime = DateTime.Now;
            TimeSpan futureTime = TimeSpan.FromSeconds(10);
            while (DateTime.Now - startTime < futureTime)
            {
                Debug.WriteLine($"Time is {DateTime.Now.ToString("hh:mm:ss")}");
            }
        }

        public void PrintviaThread()
        {
            Thread t = new Thread(Print);
            t.Start();
        }

        public void PrintviaTask()
        {
            Task.Run(Print);
        }
        public Task PrintviaTaskAwaitable()
        {
            return Task.Run(Print);
        }

        public Task<string> PrintviaTaskAwaitableResult()
        {
            return Task.Run(() => {
                Print();
                //after 10 seconds
                return "RRD";
            });
         }
    }
}
