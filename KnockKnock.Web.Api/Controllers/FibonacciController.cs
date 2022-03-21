using KnockKnock.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        private readonly IFibonacciService _fibonacciService;

        public FibonacciController(IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        [HttpGet]
        public ActionResult<long> Get([FromQuery] string n)
        {
            try
            {
                return _fibonacciService.Calculate(n);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}