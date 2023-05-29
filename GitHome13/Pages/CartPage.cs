using GitHome13.Pages.Checkout;
using OpenQA.Selenium;

namespace GitHome13.Pages
{
    internal class CartPage : BasePage, ICart
    {
        public const string url = "https://www.saucedemo.com/cart.html";

        public CartPage(WebDriver driver) : base(driver)
        {
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }

        public CheckoutPageStepOne ClickCheckout()
        {
            Driver.FindElement(By.Id("checkout")).Click();
            return new CheckoutPageStepOne(Driver);
        }

        public InventoryPage ClickContinueShopping()
        {
            Driver.FindElement(By.Id("continue-shopping")).Click();
            return new InventoryPage(Driver);
        }
    }
}
