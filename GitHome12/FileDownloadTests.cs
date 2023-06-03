using GitHome12.Pages;
using GitHome13;

namespace GitHome12
{
    internal class FileDownloadTests:GitHome13.Tests.BaseTest
    {
        [Test]
        public void DownloadTest()
        {
            string linkText = "File Download";

            new HerokuAppPage().OpenPage();
            HerokuAppPage.ClickExample(linkText);
        }
    }
}
