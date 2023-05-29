using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WindowsInput;
using WindowsInput.Native;
using GitHome13.Helpers;

namespace GitHome13.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver driver;

        [SetUp]
        public void OneTimeSetup()
        {
            driver = new ChromeDriver();
            MonitorHelper.MoveToRightMon();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}