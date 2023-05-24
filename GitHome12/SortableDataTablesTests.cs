using OpenQA.Selenium;

namespace GitHome12
{
    public class SortableDataTablesTests : BaseTest
    {
        [Test]
        public void CheckTableValue()
        {
            driver.FindElement(By.LinkText("Sortable Data Tables")).Click();

            var expectedEmail = "jdoe@hotmail.com";
            Assert.That(GetTdValue(1, 3, 3), Is.EqualTo(expectedEmail));
            Assert.That(GetTdValue(2, 3, 3), Is.EqualTo(expectedEmail));

            var expectedLastName = "Doe";
            Assert.That(GetTdValue(1, 3), Is.EqualTo(expectedLastName));
        }
  
        string GetTdValue(uint table, uint tr=1, uint td=1)
        {
            return driver.FindElement(By.XPath("//*[@id=\"table"+table+ "\"]/tbody/tr["+tr+"]/td["+td+"]")).Text;
        }
    }
}