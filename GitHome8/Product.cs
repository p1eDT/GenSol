using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome8
{
    public class Product
    {
        public string ProductName { get; set; }

        public int NumberOfCaloriest { get; set; }

        public Product (string productName, int NumberOfCalories)
        {
            ProductName = productName;
            NumberOfCaloriest = NumberOfCalories;
        }

        public int getProductCalories(string productName)
        {
            int productCalories = 0;
            if (productName == ProductName)
            {
                productCalories = NumberOfCaloriest;
            }
            return productCalories;
        }
    }
}