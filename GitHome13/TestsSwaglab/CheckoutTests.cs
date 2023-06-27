using _BussinesObject.Pages;
using _Core;
using GitHome13.Core;
using GitHome13.Pages;

namespace _Tests.TestsSwaglab
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

