using Microsoft.AspNetCore.Mvc;

namespace Distribution.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class DelateMe : ControllerBase
    {
        [HttpGet]
        public string Get() => "Hello";

    }
}
