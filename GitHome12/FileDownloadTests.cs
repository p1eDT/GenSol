using GitHome12.Pages;
using GitHome13;
using GitHome13.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GitHome12
{
    internal class FileDownloadTests:GitHome13.Tests.BaseTest
    {
        [Test]
        public void DownloadTest()
        {
            string linkText = "File Download";

            new HerokuAppPage().OpenPage().ClickExample(linkText);

            WebElement downloadFile = (WebElement)Browser.Instance.Driver.FindElement(By.XPath("//a[contains(@href,'download')]"));
            downloadFile.Click();
            Assert.IsTrue(File.Exists(DirectoryHelper.GetUserDownload() + downloadFile.Text));
        }
    }
}
