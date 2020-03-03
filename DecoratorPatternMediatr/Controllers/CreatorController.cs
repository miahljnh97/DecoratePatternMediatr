using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorPatternMediatr.Entity;
using DecoratorPatternMediatr.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DecoratorPatternMediatr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreatorController : ControllerBase
    {
        private readonly ILogger<CreatorController> _logger;

        public CreatorController(ILogger<CreatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(Creator creator)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(Creator creator)
        {
            return Ok();
        }
    }
}
