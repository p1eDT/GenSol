using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome8
{
    public class ProductCreator
    {

        /// <param name="countProducts">count Products 1-15</param>
        /// <returns></returns>
        public Product[] Create(int countProducts)
        {
            Product[] products = new Product[countProducts];

            string[] productNames = { "bacon", "chicken", "grouper", "trout", "beet", "carrot", "chick pea", "cucumber", "pea", "potato", "banana", "apple", "buckwheat", "rice", "juice", "milk" };
            Random random = new Random();

            for (int i = 0; i < products.Length; i++)
            {
                int randProduct = random.Next(1, productNames.Length);
                int randCalories = random.Next(1, 500);
                products[i] = new Product(productNames[randProduct], randCalories);
            }
            return products;
        }
    }
}
