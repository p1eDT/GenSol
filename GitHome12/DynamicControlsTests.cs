using GitHome13.Tests;
using GitHome13.Core;
using GitHome12.Pages;

namespace GitHome12
{
    internal class DynamicControlsTests : GitHome13.Tests.BaseTest
    {
        [Test]
        public void ControlsTest()
        {
            new HerokuAppPage().OpenPage();

        }
    }
}
