using GitHome13.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13
{
    internal interface ICart
    {
        static CartPage OpenCart(IWebDriver driver)
        {
            driver.FindElement(By.Id("shopping_cart_container")).Click();
            return new CartPage();
        }
    }
}
