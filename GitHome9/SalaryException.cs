using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GitHome9
{
    public class SalaryException : Exception
    {
        public int Salary { get; }

        public SalaryException(string message, int salary) : base(message)
        {
            Salary = salary;
        }

        public void InfoMessage()
        {
            Console.WriteLine($"Salary less than 100:{Salary} ");
        }
    }
}