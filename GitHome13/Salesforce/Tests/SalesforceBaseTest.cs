using GitHome13.Core;
using GitHome13.Tests;

namespace GitHome13.Salesforce.Tests
{
    public class SalesforceBaseTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Browser.Instance.NavigateToUrl("https://p1e-dev-ed.develop.my.salesforce.com/");
        }
    }
}
