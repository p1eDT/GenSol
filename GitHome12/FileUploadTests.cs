using GitHome12.Pages;
using GitHome13.Core;
using OpenQA.Selenium;

namespace GitHome12
{
    internal class FileUploadTests: GitHome13.Tests.BaseTest
    {
        [Test]
        public void UploadTest()
        {
            string linkText= "File Upload";

            new HerokuAppPage().OpenPage();
            HerokuAppPage.ClickExample(linkText);

            Browser.Instance.Driver.FindElement(By.Id("file-upload"))
                .SendKeys(DirectoryHelper.GetTestDataFolderPath() + "наклейки.jpg");
            var text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).Text;
            text = Browser.Instance.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");
        }
    }
}
