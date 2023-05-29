using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Pages
{
    internal class InventoryPage : BasePage, ICart
    {
        public const string URL_INVENTORY_PAGE = "https://www.saucedemo.com/inventory.html";

        public InventoryPage(WebDriver driver) : base(driver)
        {
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL_INVENTORY_PAGE);
            return this;
        }

        private InventoryPage AddToCart()
        {
            Driver.FindElement(By.XPath("//button [contains(text(), 'Add to cart') ]")).Click();
            return new InventoryPage(Driver);
        }

        public InventoryPage AddItemsToCart(short count = 1)
        {
            if (count > 6 || count < 1)
            {
                throw new Exception("To many items:" + count);
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    AddToCart();
                }
            }
            return this;
        }

        public CartPage OpenCart()
        {
            Driver.FindElement(By.Id("shopping_cart_container")).Click();
            return new CartPage(Driver);
        }
    }
}
