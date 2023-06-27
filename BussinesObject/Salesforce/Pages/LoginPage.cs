using _BussinesObject.Pages;
using _Core;
using _Core.Elements;
using GitHome13.Helpers;
using OpenQA.Selenium;

namespace _BussinesObject.Salesforce.Pages
{
    public class LoginPage : BasePage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Input loginButton = new(By.XPath("//input[@name='Login']"));

        private Button appLauncherButton = new(By.XPath("//div[@role='navigation']/button"));
        private Button serviceButton = new(By.XPath("//div[@aria-label='Apps']//p[text()='Service']"));

        private Button accountButton = new(By.XPath("//*[@data-id='Account']"));
        private Button contactButton = new(By.XPath("//*[@data-id='Contact']"));

        public const string url = "https://p1e-dev-ed.develop.my.salesforce.com/";

        public LoginPage()
        {

        }

        public LoginPage Login()
        {
            new LoginPage().OpenPage().TryToLoginByUserModel(UserBuilder.GetSalesforceUser());
            return this;
        }

        public LoginPage OpenHome()
        {
            appLauncherButton.GetElement().Click();
            //Browser.Instance.ExecuteScript("arguments[0].click();", serviceButton);
            serviceButton.GetElement().Click();
            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.ExecuteScript("arguments[0].click();", accountButton);
            //accountButton.GetElement().Click();
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            contactButton.GetElement().Click();
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
