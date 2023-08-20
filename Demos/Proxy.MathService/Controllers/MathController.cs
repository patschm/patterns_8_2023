using Microsoft.AspNetCore.Mvc;

namespace Proxy.MathService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }

        [Route("Add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [Route("Subtract")]
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}