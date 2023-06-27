using API.Core;
using NUnit.Framework;

namespace API.Tests
{
    public class BaseApiTest
    {
        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            apiClient = new BaseApiClient(Configuration.Api.BaseUrl);
        }
    }
}