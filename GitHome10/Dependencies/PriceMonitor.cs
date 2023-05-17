using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GitHome10.Dependencies.PriceMonitor;

namespace GitHome10.Dependencies
{
    public class PriceMonitor
    {
        public delegate void Price(int price);

        static int AveragePrice { get; set; }

        public PriceMonitor(int p)
        {
            AveragePrice = GetPrice();
            ShowPrice(p);
        }

        public static void ShowPrice(int price)
        {
            Price averagePrice;
            averagePrice = Show;
            averagePrice(price);
        }

        public static int GetPrice()
        {
            Random rnd = new Random();
            int randomPrice = rnd.Next(100, 1000);
            return randomPrice;
        }

        public static void Show(int price)
        {
            Console.WriteLine($"Price for you: {AveragePrice + price}");
        }
    }
}
