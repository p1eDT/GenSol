using _Core;
using GitHome13.Core;
using GitHome13.Helpers;
using OpenQA.Selenium;
using SeleniumTests.SwagLabs;

namespace GitHome13.Pages
{
    public class LoginPage : BasePage
    {
        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By ErrorMessage = By.CssSelector("[data-test='error'");
        private By LoginButton = By.Id("login-button");

        public const string url = "https://www.saucedemo.com/";

        public const string STANDART_USER_NAME = "standard_user";
        public const string LOCKED_OUT_USER = "locked_out_user";
        public const string PROBLEM_USER = "problem_user";
        public const string PERFORMANCE_GLITCH_USER = "performance_glitch_user";
        public const string STANDART_USER_PASSWORD = "secret_sauce";

        public LoginPage() 
        {
        }

        public InventoryPage LoginAsStandartUser()
        {
            var standartUser = new UserModel(STANDART_USER_NAME, STANDART_USER_PASSWORD);
            TryToLoginByUserModel(standartUser);
            return new InventoryPage();  
        }

        public LoginPage LoginAsLockedOutUser()
        {
            var loginAsLockedOutUser = new UserModel(LOCKED_OUT_USER, STANDART_USER_PASSWORD);
            TryToLoginByUserModel(loginAsLockedOutUser);
            return this;
        }
        
        public LoginPage LoginAsProblemtUser()
        {
            var problemUser = new UserModel(PROBLEM_USER, STANDART_USER_PASSWORD);
            TryToLoginByUserModel(problemUser);
            return this;
        }

        public InventoryPage LoginAsPerformanceGlitchUser()
        {
            var performanceGlitchUser = new UserModel(PERFORMANCE_GLITCH_USER, STANDART_USER_PASSWORD);
            TryToLoginByUserModel(performanceGlitchUser);
            WaitHelper.WaitElement(Driver, By.Id("header_container"), 6);
            return new InventoryPage();
        }

        public void TryToLoginByUserModel(UserModel userModel)
        {
            TryToLogin(userModel.Name, userModel.Password);
        }

        public void TryToLogin(string username, string password)
        {
            Driver.FindElement(UserNameInput).SendKeys(username);
            Driver.FindElement(PasswordInput).SendKeys(password);
            Driver.FindElement(LoginButton).Click();
        }

        public override LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl(url);
            return this;
        }
    }
}
