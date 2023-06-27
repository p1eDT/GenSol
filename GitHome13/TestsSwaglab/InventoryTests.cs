using GitHome13.Pages;

namespace _Tests.TestsSwaglab
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

