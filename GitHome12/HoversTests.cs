using OpenQA.Selenium;
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
            int userId = 1;

            foreach (IWebElement figure in figureDivs)
            {                
                action.MoveToElement(figure).Click().Build().Perform();
                CheckFigureDisplayValueIs(figure, "block");

                var figures = figureDivs.Where(figures => !figures.Equals(figure)).ToList();
                CheckFigureDisplayValueIs(figures[0], "none");
                CheckFigureDisplayValueIs(figures[1], "none");
                Assert.That(figure.FindElement(By.TagName("H5")).Text, Is.EqualTo("name: user"+ userId));

                figure.FindElement(By.LinkText("View profile")).Click();
                Assert.Throws<NoSuchElementException>(() => driver.FindElement(By.XPath("//*[contains(., '404')]")));

                driver.Navigate().Back();
                userId++;
            }
        }

        public void CheckFigureDisplayValueIs (IWebElement profile,string value)
        {
            Assert.That(profile.FindElement(By.ClassName("figcaption")).GetCssValue("display"), Is.EqualTo(value));
        }
    }
}