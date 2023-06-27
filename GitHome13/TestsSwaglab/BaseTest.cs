using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using GitHome13.Helpers;
using GitHome13.Core;
using _Core;

namespace _Tests.TestsSwaglab
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