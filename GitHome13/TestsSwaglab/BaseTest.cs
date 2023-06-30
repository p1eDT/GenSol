using _Core;
using Allure.Net.Commons;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace GitHome13.Tests
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest
    {
        private AllureLifecycle allure;

        [SetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
                byte[] bytes = screenshot.AsByteArray;
                allure.AddAttachment("Screenshot", "image/png", bytes);
            }

            Browser.Instance.CloseBrowser();
        }
    }
}