using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handson1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult  Get()
        {
            return Ok("get executed");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("post executed");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("put executed");
        }

        [HttpDelete]
        public IActionResult delete()
        {
            return Ok("delete executed");
        }

    }
}
