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
        public Action<int> ShowPrice { get; set; }

        public int AveragePrice { get; set; }

        public PriceMonitor(Action<int> showPrice)
        {
            AveragePrice = GetPrice();  //сразу передаем сгенерированную цену
            ShowPrice=showPrice;        //сюда пихаем делегат, в который в качестве параметра из Program.Main передан метод MyFormat, который в классе Program.
        }

        public void Show()
        {
            ShowPrice(AveragePrice);    //по сути тут метод, в который передаем интовый параметр AveragePrice. Как я понимаю, аналогично Program.MyFormat(AveragePrice)
        }

        private int GetPrice()
        {
            Random rnd = new Random();
            int randomPrice = rnd.Next(1000, 100000);
            return randomPrice;
        }
    }
}
