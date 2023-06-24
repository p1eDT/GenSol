using API.BusinessObject.ApiServiceStep;
using API.BusinessObject.Services;
using System.Net;

namespace API.Tests
{
    public class SmokeProjectTests : ApiAuthTests
    {
        [Test]
        public void GetProjectById()
        {
            var projectCode = "359704112";
            //var response = ProjectService.GetProjectByCode(projectCode);
            //Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
        }

        [Test]
        public void GetProjectById_RespenseModel()
        {
            var projectCode = "359704112";

            //var project = ApiProjectSteps.GetProjectByCode(projectCode);

            //Console.WriteLine(project.Title);
        }



    }
}