using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly MyDependency _dependency = new MyDependency();

        public IActionResult Write()
        {
            var message = $"GUID: {Guid.NewGuid().ToString()}";

            _dependency.WriteMessage(message);

            return Ok();
        }
    }
}
