using System;
using System.Data;
using System.IO.Pipes;
using System.Windows.Markup;

namespace GitHome8 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person alex = new Person("Alex", 2000);
            alex.BalanceRationToMaxCalories();
        }
    }
}