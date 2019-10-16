using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Api;

namespace Tests.Api
{
    public class ApiWebApplicationFactory : WebApplicationFactory<Startup> { }
}