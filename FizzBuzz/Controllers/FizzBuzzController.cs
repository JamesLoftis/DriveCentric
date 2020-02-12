using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Helpers;
using FizzBuzz.Trigger;

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
        public string[] Post([FromBody] string params = null)
        {
            //TODO: MUST PARSE string JSON to 2 values. One int and one class TriggerCollection
            //TODO: OLD PARAMS int? maximum, TriggerCollection triggerParam
            //TODO: ALSO NEEDS A LOT OF TESTS
            const int MINIMUM = 1;
            var triggers = triggerParam ?? new TriggerCollection();
            if(maximum.IsValid())
            {
                return fizzBuzzModel.CreateFizzBuzzCollection(MINIMUM, (int)maximum, triggers).ToArray();
            }
            else 
            {
                throw new ArgumentException($"Error. {maximum} is not valid as a maximum number.");
            }
        }
    }
}
