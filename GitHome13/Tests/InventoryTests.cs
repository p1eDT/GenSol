using GitHome13.Pages;
using GitHome13.Tests;

namespace GitHome13.Tests
{
    internal class InventoryTests : SaleforceBaseTest
    {
        [Test]
        public void AddItemsToCart()
        {
            new LoginPage().OpenPage().LoginAsStandartUser()
               .AddItemsToCart(2);

        }

        [Test]
        public void GoToCart()
        {
            new LoginPage().OpenPage().LoginAsStandartUser()
                .AddItemsToCart(6)
                .OpenCart();
        }
    }
}

