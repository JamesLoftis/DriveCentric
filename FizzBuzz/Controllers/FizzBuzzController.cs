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
        FizzBuzzModel model;
        public FizzBuzzController()
        {
             model = new FizzBuzzModel();
        }

        [HttpPost]
        public string[] Post([FromBody]RequestDto dto) => model.CreateFizzBuzzCollection(dto).ToArray();
        
    }
}
