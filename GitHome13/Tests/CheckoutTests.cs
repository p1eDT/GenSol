using GitHome13.Pages;
using GitHome13.Tests;

namespace GitHome13.Tests
{
    internal class CheckoutTests : SwagLabBaseTest
    {

        [Test]
        public void EndToEndTest()
        {
            new LoginPage(driver).OpenPage().LoginAsStandartUser()
                .AddItemsToCart(6)
                .OpenCart()
                .ClickCheckout()
                .FillingUserData()
                .ClickContinue()
                .ClickFinish()
                .ClickBackHome();
        }
    }
}

