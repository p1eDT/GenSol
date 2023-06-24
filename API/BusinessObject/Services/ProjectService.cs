﻿using API.BusinessObject.Model;
using API.Core;
using NUnit.Framework.Constraints;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.BusinessObject.Services
{
    public class ProjectService : BaseService
    {
        public string ProjectEndpoint = "/project";
        public string GetProjectByCodeEndpoint = "/project/{code}";

        public ProjectService() : base("https://api.qase.io/v1")
        {
            apiClient.AddToken("139648cd7fae0460f1e38bd794aaf54a22505db0680705fabe0efeb918d968c2");
        }

        public RestResponse GetProjectByCode(string code)
        {
            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }

        public RestResponse CreateProject(CreateProjectModel project)
        {
            var request = new RestRequest(ProjectEndpoint, Method.Post);
            request.AddBody(project);
            return apiClient.Execute(request);
        }

        public Project GetProjectByCode<ProjectType>(string code) where ProjectType : Project
        {
            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute<CommonResultResponse<Project>>(request).Result;
        }
    }
}