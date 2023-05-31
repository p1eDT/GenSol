using GitHome13.Pages;

namespace GitHome13.Tests
{
    internal class LoginTest:SwagLabBaseTest
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
