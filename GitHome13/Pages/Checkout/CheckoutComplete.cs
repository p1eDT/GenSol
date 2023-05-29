using OpenQA.Selenium;


namespace GitHome13.Pages.Checkout
{
    internal class CheckoutComplete : BasePage, ICart
    {
        public const string URL_CHECKOUT_COMPLETE = "https://www.saucedemo.com/checkout-complete.html";

        public CheckoutComplete(WebDriver driver) : base(driver)
        {
        }

        public override BasePage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL_CHECKOUT_COMPLETE);
            return this;
        }

        public InventoryPage ClickBackHome()
        {
            Driver.FindElement(By.Id("back-to-products")).Click();
            return new InventoryPage(Driver);
        }
    }
}
