using System;
using System.Reflection;
using Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly ITellVersions _versioner;

        public VersionController(ITellVersions versioner)
        {
            _versioner = versioner ?? throw new ArgumentNullException(nameof(versioner));
        }

        // GET api/version
        [HttpGet]
        public ActionResult Get()
        {
            var result = _versioner.GetVersion();
            return Ok(result);
        }
    }
}