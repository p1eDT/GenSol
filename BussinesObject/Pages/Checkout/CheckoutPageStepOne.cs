using _Core;
using Bogus;
using OpenQA.Selenium;
using SeleniumTests.SwagLabs;

namespace _BussinesObject.Pages.Checkout
{
    public class CheckoutPageStepOne : BasePage
    {
        private By cancelButton = By.Id("cancel");
        private By continueButton = By.Id("continue");

        public const string URL_CHECKOUT_STEP_ONE = "https://www.saucedemo.com/checkout-step-one.html";

        public CheckoutPageStepOne()
        {
        }

        public override BasePage OpenPage()
        {
            Browser.Instance.NavigateToUrl(URL_CHECKOUT_STEP_ONE);
            return this;
        }

        public CartPage ClickCancel()
        {
            Driver.FindElement(cancelButton).Click();
            return new CartPage();
        }

        public CheckoutPageStepTwo ClickContinue()
        {
            Driver.FindElement(continueButton).Click();
            return new CheckoutPageStepTwo();
        }

        public CheckoutPageStepOne FillingUserData()
        {
            Faker faker = new Faker();
            var user = new UserModel(faker.Name.FirstName(), faker.Name.LastName());
            Driver.FindElement(By.XPath("//input[@data-test='firstName']")).SendKeys(user.Name);
            Driver.FindElement(By.XPath("//input[@data-test='lastName']")).SendKeys(user.Password);
            Driver.FindElement(By.XPath("//input[@data-test='postalCode']")).SendKeys(faker.Address.ZipCode());
            return this;
        }
    }
}
