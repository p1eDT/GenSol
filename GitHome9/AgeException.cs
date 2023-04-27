using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome9
{
    public class AgeException : Exception
    {
        public int Age { get; }

        public AgeException(string message, int age) : base(message)
        {
            Age = age;
        }

        public void InfoMessage()
        {
            Console.WriteLine($"Your age is below 18: {Age} ");
        }
    }
}