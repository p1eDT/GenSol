using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome7
{
    public class Cleaner : Employee
    {
        public Cleaner(string name) : base(name)
        {
        }

        public override void CanDo()
        {
            WhatHeDo();
        }
        public void WhatHeDo()
        {
            Console.WriteLine("Cleaning");
        }
    }
}
