using Example2.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Example2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //private readonly MyDependency _dependency = new MyDependency();

        private readonly IMyDependency _dependency;

        public HomeController(IMyDependency myDependency)
        {
            this._dependency = myDependency;
        }

        [HttpGet("[action]")]
        public IActionResult Write()
        {
            var message = $"GUID: {Guid.NewGuid()}";

            _dependency.WriteMessage(message);

            return Ok();
        }
    }
}
