using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Helpers;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IModel fizzBuzzModel;
        public FizzBuzzController(IModel model)
        {
            fizzBuzzModel = model ?? new FizzBuzzModel();
        }

        [HttpPost]
        public string[] Post([FromBody] string content = null)
        {
            if(string.IsNullOrEmpty(content)){
                throw new ArgumentException($"Error! Body did not contain content.");
            }
            
            return fizzBuzzModel.CreateFizzBuzzCollection(content).ToArray();
        }
    }
}
