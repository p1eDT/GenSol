using API.BusinessObject.Model;
using API.BusinessObject.Services;
using Newtonsoft.Json;
using System.Net;

namespace API.BusinessObject.ApiServiceStep
{
    public class ApiProjectSteps : ProjectService
    {
        public new Project GetProjectByCode(string code)
        {
            var response = base.GetProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content).Result;
        }
    }
}