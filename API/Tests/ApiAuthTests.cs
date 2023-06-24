using NUnit.Framework;
using Core.Configuration;
using RestSharp;
using API.BusinessObject;
using API.BusinessObject.ApiServiceStep;
using API.BusinessObject.Services;

namespace API.Tests
{
    public class ApiAuthTests : BaseApiTest
    {
        protected ProjectService projectService;
        protected ApiProjectSteps apiProjectSteps;

        [OneTimeSetUp]
        public void SetUp()
        {
            projectService = new ProjectService();
            apiProjectSteps = new ApiProjectSteps();
        }

        [OneTimeSetUp]
        public void InitialService()
        {
            apiClient.AddToken(Configuration.Api.Token);
        }
    }
}