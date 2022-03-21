using System;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "f4e8e50f-b726-4abf-bff6-4f85fdd80dc1";
        }
    }
}