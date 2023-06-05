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

        public const string url = "https://p1e-dev-ed.develop.my.salesforce.com/";

        public LoginPage()
        {

        }

        public NewAccountModal Login()
        {
            new LoginPage().OpenPage().TryToLoginByUserModel(UserBuilder.GetSalesforceUser());

            Browser.Instance.NavigateToUrl("https://p1e-dev-ed.develop.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public void TryToLoginByUserModel(UserModel userModel)
        {
            TryToLogin(userModel.Name, userModel.Password);
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
