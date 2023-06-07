using GitHome13.Core;
using GitHome13.Pages.Checkout;
using OpenQA.Selenium;

namespace GitHome13.Pages
{
    internal class CartPage : BasePage, ICart
    {
        private By continueButton = By.Id("continue-shopping");
        private By checkoutButton = By.Id("checkout");

        public const string url = "https://www.saucedemo.com/cart.html";

        public CartPage()
        {
        }

        public override BasePage OpenPage()
        {
            Browser.Instance.NavigateToUrl(url);
            return this;
        }

        public CheckoutPageStepOne ClickCheckout()
        {
            Driver.FindElement(By.Id("checkout")).Click();
            return new CheckoutPageStepOne( );
        }

        public InventoryPage ClickContinueShopping()
        {
            Driver.FindElement(continueButton).Click();
            return new InventoryPage();
        }
    }
}
