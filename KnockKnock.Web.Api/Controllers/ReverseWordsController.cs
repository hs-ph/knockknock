using System.Web;
using KnockKnock.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;

namespace KnockKnock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseWordsController : ControllerBase
    {
        private readonly IReverseWordsService _reverseWordsService;

        public ReverseWordsController(IReverseWordsService reverseWordsService)
        {
            _reverseWordsService = reverseWordsService;
        }

        [HttpGet]
        public ActionResult<string> Get([FromQuery] string sentence)
        {
            try
            {
                return _reverseWordsService.Reverse(sentence);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}