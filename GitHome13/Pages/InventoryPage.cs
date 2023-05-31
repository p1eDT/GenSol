using GitHome13.Core;
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
        private By openCartLink = By.Id("shopping_cart_container");
        private By addToCartButton = By.XPath("//button [contains(text(), 'Add to cart') ]");

        public const string URL_INVENTORY_PAGE = "https://www.saucedemo.com/inventory.html";

        public InventoryPage()
        {
        }

        public override BasePage OpenPage()
        {
            Browser.Instance.NavigateToUrl(URL_INVENTORY_PAGE);
            return this;
        }

        private InventoryPage AddToCart()
        {
            Driver.FindElement(addToCartButton).Click();
            return new InventoryPage();
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
            Driver.FindElement(openCartLink).Click();
            return new CartPage();
        }
    }
}
