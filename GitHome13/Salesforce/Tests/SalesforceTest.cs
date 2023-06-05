using GitHome13.Core;
using GitHome13.Salesforce.Pages;
using OpenQA.Selenium;

namespace GitHome13.Salesforce.Tests
{
    internal class SalesforceTest : SalesforceBaseTest
    {
        [Test]
        public void LoginUser()
        {
            var name = UserBuilder.GetFakerUser().Name;
            string expectedAlert = string.Format($"Account \"{name}\" was created.");

            new LoginPage().OpenPage().Login().CreateAccount(name, "Other");
            var textAlert = Browser.Instance.Driver.FindElement(By.XPath("//div[@data-key='success']/div/descendant::span")).Text;

            Assert.That(textAlert, Is.EqualTo(expectedAlert));

        }
    }
}
