﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
    internal class Infant : Man
    {
        public override void Play()
        {
            Console.WriteLine("Infant is playing");
        }
    }
}
