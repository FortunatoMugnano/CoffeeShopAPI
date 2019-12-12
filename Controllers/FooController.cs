using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeShopAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FooController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FooController> _logger;

        public FooController(ILogger<FooController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<string> Post()
        {
            return new List<string> { "Fortunato", "Mugnano" };
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string> { "foo", "bar", "baz", "from the foo controller" };
        }

        
        [HttpGet("{id}")]
        public IEnumerable<string> GetOne(int id)
        {
            return new List<string> { "I", "Got", "One" };
        }
    }
}
