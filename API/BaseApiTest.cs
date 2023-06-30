using Allure.Net.Commons;
using NUnit.Allure.Core;

namespace API
{
    [AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class BaseApiTest
    {
        private AllureLifecycle allure;

        [OneTimeSetUp]
        public void Initial()
        {
            //    apiClient = new BaseApiClient("https://api.qase.io/v1");
            //    apiClient.AddToken("139648cd7fae0460f1e38bd794aaf54a22505db0680705fabe0efeb918d968c2");
        }

        [SetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;
        }
    }
}