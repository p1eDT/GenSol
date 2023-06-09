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
 
            new LoginPage().OpenPage().Login();

        }

        [Test]
        public void CreateAccount() 
        {
            var name = UserBuilder.GetFakerUser().Name;
            string expectedAlert = MessageContainer.AccountCreated(name);

            new LoginPage().OpenPage().Login().OpenHome().OpenNewAccountModal().CreateAccount(name, "Other");
            var textAlert = Browser.Instance.Driver.FindElement(By.XPath("//div[@data-key='success']/div/descendant::span")).Text;

            Assert.That(textAlert, Is.EqualTo(expectedAlert));
        }

        [Test]
        public void CreateContact()
        {
            var name = UserBuilder.GetFakerUser().Name;
           // string expectedAlert = MessageContainer.AccountCreated(name);

            new LoginPage().OpenPage().Login().OpenHome().OpenNewContactModal().CreateContact(name, "Other");

        }
    }
}
