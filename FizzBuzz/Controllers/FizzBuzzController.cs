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
        private readonly FizzBuzzModel fizzBuzzModel;
        public FizzBuzzController(ILogger<FizzBuzzController> logger)
        {
            _logger = logger;
            fizzBuzzModel = new FizzBuzzModel();
        }

        [HttpGet]
        public string[] Get()
        {
            return fizzBuzzModel.GetFizzBuzzCollection(1, 100).ToArray();
        }
    }
}
