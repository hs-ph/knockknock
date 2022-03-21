using System;
using KnockKnock.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleTypeController : ControllerBase
    {
        private readonly ITriangleService _triangleService;

        public TriangleTypeController(ITriangleService triangleService)
        {
            _triangleService = triangleService;
        }

        [HttpGet]
        public ActionResult<string> Get([FromQuery]int a, [FromQuery] int b, [FromQuery] int c)
        {
            return _triangleService.GetTriangleType(a, b, c);
        }
    }
}