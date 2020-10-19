using Example1.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Example1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly MyDependency _dependency = new MyDependency();

        [HttpGet("[action]")]
        public IActionResult Write()
        {
            var message = $"GUID: {Guid.NewGuid()}";

            _dependency.WriteMessage(message);

            return Ok();
        }
    }
}
