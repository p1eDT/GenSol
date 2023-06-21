using _Core;
using OpenQA.Selenium;


namespace GitHome13.Pages.Checkout
{
    public class CheckoutComplete : BasePage, ICart
    {
        private By backHomeButton = By.Id("back-to-products");
        public const string URL_CHECKOUT_COMPLETE = "https://www.saucedemo.com/checkout-complete.html";

        public CheckoutComplete()
        {
        }

        public override BasePage OpenPage()
        {
            Browser.Instance.NavigateToUrl(URL_CHECKOUT_COMPLETE);
            return this;
        }

        public InventoryPage ClickBackHome()
        {
            Driver.FindElement(backHomeButton).Click();
            return new InventoryPage();
        }
    }
}
