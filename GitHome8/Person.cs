using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitHome8
{
    public class Person
    {
        public string Name { get; set; }

        public int MaxNumberOfCalories { get; set; }

        public Dictionary<DayOfWeek, List<string>> Ration { get; set; }

        public Person(string name, int maxNumberOfCalories)
        { 
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
            Ration = CreateRation();
        }

        public Dictionary<DayOfWeek, List<string>> CreateRation ()
        {
            RationCreator ration = new RationCreator();
            return ration.Create();
        }

        public int CheckNumberOfCalories(DayOfWeek day)
        {
            ProductCreator productCreate = new ProductCreator();

            Product[] products = productCreate.Create(1);

            int calories = 0;
            foreach (string produ in Ration[(DayOfWeek) Enum.Parse(typeof(DayOfWeek), day.ToString())]) 
            {
                calories+= products[0].getProductCalories(produ);
            }
            return calories;
        }

        public void BalanceRationToMaxCalories()
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                int numberOfCalories = CheckNumberOfCalories(day);
                do
                {             
                    Ration[day].RemoveAt(0);
                    numberOfCalories = CheckNumberOfCalories(day);
                }
                while (numberOfCalories > MaxNumberOfCalories);
            }
        }
    }
}