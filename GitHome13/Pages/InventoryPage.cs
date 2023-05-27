using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Pages
{
    internal class InventoryPage : BasePage
    {
        public const string url = "https://www.saucedemo.com/inventory.html";
        public InventoryPage(WebDriver driver) : base(driver)
        {
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
