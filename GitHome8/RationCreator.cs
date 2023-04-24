using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome8
{
    public class RationCreator
    {
        public Dictionary<DayOfWeek, List<string>> Create()
        {
            int countOfProduct = 15;
            var ration = new Dictionary<DayOfWeek, List<string>>();

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                List<string> productDay = productOfOneDay(countOfProduct);
                ration.Add(day, productDay);
            }
            return ration;
        }

        /// <summary>
        /// Creating random products for one day in a given quantity
        /// </summary>
        /// <param name="countOfProduct">count products</param>
        /// <returns>List of products</returns>
        public List<string> productOfOneDay(int countOfProduct)
        {
            ProductCreator productCreator = new ProductCreator();
            Product[] products = productCreator.Create(countOfProduct);

            List<string> productList = new List<string>();

            Random random = new Random();

            for (int i = 0; i <= 5; i++)
            {
                int randIndex = random.Next(0, countOfProduct);
                productList.Add(products[randIndex].ProductName);
            }
            return productList;
        }
    }
}