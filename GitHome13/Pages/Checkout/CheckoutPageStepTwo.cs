using OpenQA.Selenium;

namespace GitHome13.Pages.Checkout
{
    internal class CheckoutPageStepTwo : BasePage
    {
        public const string URL_CHECKOUT_STEP_TWO = "https://www.saucedemo.com/checkout-step-two.html";

        public CheckoutPageStepTwo(WebDriver driver) : base(driver)
        {
            
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL_CHECKOUT_STEP_TWO);
            return this;
        }

        public InventoryPage ClickCancel()
        {
            Driver.FindElement(By.Id("cancel")).Click();
            return new InventoryPage(Driver);
        }

        public CheckoutComplete ClickFinish()
        {
            Driver.FindElement(By.Id("finish")).Click();
            return new CheckoutComplete(Driver);
        }
    }
}
