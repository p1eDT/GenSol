using GitHome13.Core;
using GitHome13.Core.Elements;
using GitHome13.Helpers;
using GitHome13.Pages;
using OpenQA.Selenium;
using SeleniumTests.SwagLabs;

namespace GitHome13.Salesforce.Pages
{
    internal class LoginPage : BasePage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Input loginButton = new(By.XPath("//input[@name='Login']"));

        private Button contactButton = new(By.XPath("//*[@data-id-'Contact']//span"));

        public const string url = "https://p1e-dev-ed.develop.my.salesforce.com/";

        public LoginPage()
        {

        }

        public LoginPage Login()
        {
            new LoginPage().OpenPage().TryToLoginByUserModel(UserBuilder.GetSalesforceUser());

            Browser.Instance.NavigateToUrl("https://p1e-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("https://p1e-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            //Browser.Instance.NavigateToUrl("https://p1e-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id-'Contact']//span"));

            Browser.Instance.ExecuteScript("arguments[0].click();", contactTab);

            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewContactModal();
        }

        public LoginPage TryToLoginByUserModel(UserModel userModel)
        {
            TryToLogin(userModel.Name, userModel.Password);
            return this;
        }

        public void TryToLogin(string username, string password)
        {
            userNameInput.GetElement().SendKeys(username);
            passwordInput.GetElement().SendKeys(password);
            loginButton.GetElement().Click();
        }

        public override LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl(url);
            return this;
        }
    }
}
