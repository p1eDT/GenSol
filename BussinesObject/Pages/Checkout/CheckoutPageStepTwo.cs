using _Core;
using OpenQA.Selenium;

namespace _BussinesObject.Pages.Checkout
{
    public class CheckoutPageStepTwo : BasePage
    {
        private By cancelButton = By.Id("cancel");
        private By finishButton = By.Id("finish");

        public const string URL_CHECKOUT_STEP_TWO = "https://www.saucedemo.com/checkout-step-two.html";

        public CheckoutPageStepTwo()
        {

        }

        public override BasePage OpenPage()
        {
            Browser.Instance.NavigateToUrl(URL_CHECKOUT_STEP_TWO);
            return this;
        }

        public InventoryPage ClickCancel()
        {
            Driver.FindElement(cancelButton).Click();
            return new InventoryPage();
        }

        public CheckoutComplete ClickFinish()
        {
            Driver.FindElement(finishButton).Click();
            return new CheckoutComplete();
        }
    }
}
