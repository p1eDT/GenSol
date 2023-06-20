using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using GitHome13.Helpers;
using GitHome13.Core;

namespace GitHome13.Tests
{
    [TestFixture]
    public class BaseTest
    {

        [SetUp]
        public void OneTimeSetup()
        {

        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}