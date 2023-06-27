﻿namespace API.Configuration;

public class ApiConfiguration : IConfiguration
{
    public string SectionName => "Api";
    public string BaseUrl { get; set; }

    public string Token { get; set; }
}