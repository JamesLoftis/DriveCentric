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
            var json = "{\"Maximum\": \"100\", \"Triggers\": [{\"Multiple\": 3,\"Word\": \"Fizz\"   },{\"Multiple\": 5,\"Word\": \"Buzz\"}]}";

            var obj =  json.ParseJson();
            var comparisonObj = new RequestDto()
            {
                Maximum = 100,
                Triggers = new List<Trigger>() 
                { 
                    new Trigger(){Multiple = 3, Word = "Fizz" },
                    new Trigger(){Multiple = 5, Word = "Buzz" }
                }
            };
            
            Assert.IsTrue(obj.IsEqualTo(comparisonObj));
        }
    }
}