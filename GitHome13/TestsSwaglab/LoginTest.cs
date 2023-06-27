using GitHome13.Pages;

namespace _Tests.TestsSwaglab
{
    internal class LoginTest : SaleforceBaseTest
    {
        [Test]
        public void Login_StandartUser()
        {
            var inventoryPage = new LoginPage().OpenPage().LoginAsStandartUser();
        }

        [Test]
        public void Login_PerformanceGlitchUser()
        {
            var InventoryPage = new LoginPage().OpenPage().LoginAsPerformanceGlitchUser();
        }
    }
}
