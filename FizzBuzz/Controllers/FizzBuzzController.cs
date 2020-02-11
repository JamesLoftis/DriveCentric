using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly ILogger<FizzBuzzController> _logger;

        public FizzBuzzController(ILogger<FizzBuzzController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public FizzBuzz Get()
        {
            return FizzBuzzModel.GetFizzBuzz();
        }
    }
}
