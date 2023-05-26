using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GitHome12
{
    internal class InputTests:BaseTest
    {

        [Test]
        public void EnterNumber()
        {
            var expectedUrl = "https://the-internet.herokuapp.com/inputs";
            
            driver.FindElement(By.LinkText("Inputs")).Click();
            Assert.AreEqual(expectedUrl, driver.Url);

            var input = driver.FindElement(By.TagName("input"));

            input.SendKeys("100");
            input.Clear();

            input.SendKeys("100");
            input.SendKeys(Keys.ArrowUp + Keys.ArrowUp);

        }
    }
}