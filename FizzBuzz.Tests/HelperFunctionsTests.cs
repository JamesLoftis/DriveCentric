using System.Security.AccessControl;
using NUnit.Framework;
using FizzBuzz.Controllers;
using FizzBuzz;
using System.Linq;
using System;
using Newtonsoft.Json;
using FizzBuzz.Helpers;
using FizzBuzz.Dto;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class HelperFunctionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ParseJson_Test()
        {
            var json = "{\"Maximum\": \"100\", \"TriggerDtoCollection\": [{\"Multiple\": 3,\"Word\": \"Fizz\"   },{\"Multiple\": 5,\"Word\": \"Buzz\"}]}";

            var obj =  json.ParseJson();
            var comparisonObj = new ResponseDto()
            {
                Maximum = 100,
                TriggerDtoCollection = new List<TriggerDto>() 
                { 
                    new TriggerDto(){Multiple = 3, Word = "Fizz" },
                    new TriggerDto(){Multiple = 5, Word = "Buzz" }
                }
            };
            
            Assert.IsTrue(obj.IsEqualTo(comparisonObj));
        }
    }
}