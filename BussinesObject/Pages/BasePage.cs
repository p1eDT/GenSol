using OpenQA.Selenium;
using GitHome13.Core;
using _Core;

namespace GitHome13.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;

        public BasePage()
        {
            Driver = Browser.Instance.Driver;
        }

        public abstract BasePage OpenPage();
    }
}
