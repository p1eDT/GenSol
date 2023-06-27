using _BussinesObject;
using GitHome13.Salesforce.Pages;

namespace _Tests.Salesforce.Tests
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
            string expectedAlert = MessageContainer.ExpectedAlert("Account", name, State.created);

            new LoginPage().OpenPage().Login().OpenHome().OpenNewAccountModal().CreateAccount(name, "Other");

            var textAlert = MessageContainer.GetAlertText();
            Assert.That(textAlert, Is.EqualTo(expectedAlert));
        }

        [Test]
        public void CreateContact()
        {
            var name = UserBuilder.GetFakerUser().Name;
            string expectedAlert = MessageContainer.ExpectedAlert("Contact", name, State.created);

            new LoginPage().OpenPage().Login().OpenHome().OpenNewContactModal().CreateContact(name, "Alex");

            var textAlert = MessageContainer.GetAlertText();
            Assert.That(textAlert, Is.EqualTo(expectedAlert));
        }

        [Test]
        public void DeleteContact()
        {
            var name = "Richard";
            string expectedAlert = MessageContainer.ExpectedAlert("Contact", name, State.deleted);

            new LoginPage().OpenPage().Login().OpenHome().OpenNewContactModal().DeleteContact(name);

            var textAlert = MessageContainer.GetAlertText();
            Assert.That(textAlert, Is.EqualTo(expectedAlert));
        }
    }
}
