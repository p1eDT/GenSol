using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GitHome12
{
    internal class DropDownTests:BaseTest
    {

        [Test]
        public void SelectOptions()
        {        
            driver.FindElement(By.LinkText("Dropdown")).Click();
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));

            select.SelectByIndex(2);

            Assert.That(() => select.SelectByText("Please select an option"), Throws.InvalidOperationException);
        }
    }
}