using OpenQA.Selenium;

namespace GitHome12
{
    internal class AddRemoveElementsTests:BaseTest
    {

        [Test]
        public void AddRemoveButton()
        {
            var expectedUrl = "https://the-internet.herokuapp.com/add_remove_elements/";

            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Assert.AreEqual(expectedUrl, driver.Url);

            driver.FindElement(By.TagName("Button")).Click();
            var addedButton= driver.FindElement(By.ClassName("added-manually"));
            Assert.IsNotNull(addedButton);
            
            addedButton.Click();
            Assert.IsEmpty(driver.FindElements(By.ClassName("added-manually")));
        }
    }
}