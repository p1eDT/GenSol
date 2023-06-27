using _Core;
using _Tests.TestsSwaglab;

namespace _Tests.Salesforce.Tests
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
