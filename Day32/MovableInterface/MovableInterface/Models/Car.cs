using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    internal class Car : Vehicle

    {
        public Car(string brand, string chasisNo) : base(brand, chasisNo)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Car {Brand} {ChasisNo} is Moving...");
        }
    }
}
