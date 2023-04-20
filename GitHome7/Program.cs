using System;

namespace GitHome7 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cleaner cleaner = new Cleaner("Vasya");
            Cook cook = new Cook("T.Valya");
            Manager manager = new Manager("Lopar");

            manager.Work();
            cleaner.Work();
            cook.Work();
        }
    }
}