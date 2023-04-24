using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome7
{
    public class Cleaner : Employee, IPositionable, IWork
    {
        public Positions Position { get; set; } = Positions.Cleaner;

        public Cleaner(string name) : base(name)
        {

        }

        public override string[] WhatDo()
        {
            string[] doing = { "Cleaning" };
            return doing;
        }

        public override string ToString()
        {
            return $"{Position}";
        }

        public void Work()
        {
            foreach (string doing in WhatDo())
            {
                Console.Write(Position.ToString() + " " + Name + " is " + doing + "\n\r");
            }
        }
    }
}