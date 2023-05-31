using OpenQA.Selenium;
using GitHome13.Core;

namespace GitHome13.Pages
{
    internal abstract class BasePage
    {
        protected IWebDriver Driver;

        public BasePage()
        {
            Driver = Browser.Instance.Driver;
        }

        public abstract BasePage OpenPage();
    }
}
