using _Core.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _Core
{
    public class Browser
    {
        private static Browser instance = null;
        private IWebDriver driver;

        public IWebDriver Driver { get { return driver; } }

        public static Browser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Browser();
                }

                return instance;
            }
        }

        private Browser()
        {
            var isHeadless = bool.Parse(TestContext.Parameters.Get("Headless"));
            var wait = int.Parse(TestContext.Parameters.Get("ImplicityWait"));
            var isMoveToRightMonitor = bool.Parse(TestContext.Parameters.Get("MoveToRightMonitor"));

            if (isHeadless)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");

                driver = new ChromeDriver(options);
            }
            else
            {
                driver = new ChromeDriver();

                if (isMoveToRightMonitor)
                {
                    MonitorHelper.MoveToRightMon();
                }
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
            driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            driver?.Dispose();
            instance = null;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void AcceptDismiss()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public void ContextClick(By by)
        {
            Actions action = new Actions(Browser.Instance.Driver);
            action.ContextClick(Browser.Instance.Driver.FindElement(by)).Build().Perform();
        }

        public string GetAlertText()
        {
            return driver.SwitchTo().Alert().Text;
        }
        public void SwitchToFrame(string id)
        {
            driver.SwitchTo().Frame(id);
        }

        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }

        public object? ExecuteScript(string scipt, object argument = null)
        {
            try
            {

                return ((IJavaScriptExecutor)driver).ExecuteScript(scipt, argument);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}