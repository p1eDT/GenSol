using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Browser;
using OpenQA.Selenium.Interactions;

namespace GitHome12
{
    public class HoversTests : BaseTest
    {
        [Test]
        public void CheckProfiles()
        {
            driver.FindElement(By.LinkText("Hovers")).Click();

            List<IWebElement> figureDivs=driver.FindElements(By.ClassName("figure")).ToList();
            Actions action = new Actions(driver);

            foreach(IWebElement figure in figureDivs)
            {
                action.MoveToElement(figure).Click().Build().Perform();
                Assert.That(figure.FindElement(By.ClassName("figcaption")).GetCssValue("display"), Is.EqualTo("block"));
                Assert.That(figure.FindElement(By.TagName("H5")).Text, Is.EqualTo("name: user1"));
                figure.FindElement(By.LinkText("View profile")).Click();
                driver.Navigate().Back();
            }
        }
    }
}