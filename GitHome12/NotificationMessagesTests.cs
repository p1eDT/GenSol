using OpenQA.Selenium;
using System.Linq;
using System.Text.RegularExpressions;

namespace GitHome12
{
    public class NotificationMessagesTests : BaseTest
    {
        [Test]
        public void CheckNotifications()
        {
            string expectedNotifications = "Action successful";

            driver.FindElement(By.LinkText("Notification Messages")).Click();

            var notice = GetNotification();
            int countTry = 0;

            do
            {
                CloseNotification();
                GenerateNotification();
                notice = GetNotification();

                countTry++;
            }
            while
            (
                Is.Equals(expectedNotifications, notice)
            );

            Assert.Pass($"Action successful received in {countTry} attempts");
        }

        public void CloseNotification()
        {
            driver.FindElement(By.XPath("//*[@id=\"flash\"]/a")).Click();
        }

        public void GenerateNotification()
        {
            driver.FindElement(By.LinkText("Click here")).Click();
        }

        public string GetNotification()
        {
            return Regex.Replace(driver.FindElement(By.Id("flash")).Text, @"[^A-Za-z ]+", String.Empty);
        }
    }
}