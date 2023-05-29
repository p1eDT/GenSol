using Bogus;
using OpenQA.Selenium;
using SeleniumTests.SwagLabs;

namespace GitHome13.Pages.Checkout
{
    internal class CheckoutPageStepOne : BasePage
    {
        public const string URL_CHECKOUT_STEP_ONE = "https://www.saucedemo.com/checkout-step-one.html";

        public CheckoutPageStepOne(WebDriver driver) : base(driver)
        {
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL_CHECKOUT_STEP_ONE);
            return this;
        }

        public CartPage ClickCancel()
        {
            Driver.FindElement(By.Id("cancel")).Click();
            return new CartPage(Driver);
        }

        public CheckoutPageStepTwo ClickContinue() 
        {
            Driver.FindElement(By.Id("continue")).Click();
            return new CheckoutPageStepTwo(Driver);
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
