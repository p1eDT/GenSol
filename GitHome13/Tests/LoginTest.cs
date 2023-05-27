using GitHome13.Pages;

namespace GitHome13.Tests
{
    internal class LoginTest:SwagLabBaseTest
    {
        [Test]
        public void Login_StandartUser()
        {
            var InventoryPage = new LoginPage(driver).OpenPage().LoginAsStandartUser();
        }
    }
}
