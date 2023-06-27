using _Core;
using GitHome13.Core;
using GitHome13.Pages;
using GitHome13.Tests;

namespace GitHome13.Tests
{
    internal class CheckoutTests : SaleforceBaseTest
    {

        [Test]
        public void EndToEndTest()
        {
            new LoginPage().OpenPage().LoginAsStandartUser()
                .AddItemsToCart(6)
                .OpenCart()
                .ClickCheckout()
                .FillingUserData()
                .ClickContinue()
                .ClickFinish()
                .ClickBackHome();

            Assert.That(Browser.Instance.Driver.Url, Is.EqualTo(InventoryPage.URL_INVENTORY_PAGE));
        }
    }
}

