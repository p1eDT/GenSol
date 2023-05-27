using OpenQA.Selenium;
using System;

namespace GitHome13.Pages
{
    internal abstract class BasePage
    {
        protected WebDriver Driver;

        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }

        public abstract BasePage OpenPage();
    }
}
