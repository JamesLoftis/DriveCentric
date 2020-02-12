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
        private readonly IModel fizzBuzzModel;
        public FizzBuzzController(IModel model)
        {
            fizzBuzzModel = model ?? new FizzBuzzModel();
        }

        [HttpPost]
        public RequestDto Post([FromBody]RequestDto args)
        {
            // try{
                // if(string.IsNullOrEmpty(content)){
                //     throw new ArgumentException($"Error! Body did not contain content.");
                // }
                return args;
                // return fizzBuzzModel.CreateFizzBuzzCollection(content).ToArray();
            // } catch(Exception ex)
            // {
            //     var returnVal = new List<string>();
            //     returnVal.Add(ex.Message);
            //     return  returnVal.ToArray();
            // }
        }
    }
}
