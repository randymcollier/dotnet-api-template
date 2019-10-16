using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Template.Api;

namespace Template.Tests.Api
{
    public class ApiWebApplicationFactory : WebApplicationFactory<Startup> { }
}