using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Helpers;
using FizzBuzz.Dto;
using System.Text.Json;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        [HttpPost]
        public string[] Post([FromBody]RequestDto dto)
        {
            var model = new FizzBuzzModel();
            return model.CreateFizzBuzzCollection(dto).ToArray();
        }
    }
}
