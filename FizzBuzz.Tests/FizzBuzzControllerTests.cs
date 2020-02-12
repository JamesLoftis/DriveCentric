using NUnit.Framework;
using FizzBuzz.Controllers;
using FizzBuzz;
using System.Linq;
using System;
using Newtonsoft.Json;
using FizzBuzz.Helpers;

namespace FizzBuzz.Tests
{
    public class FizzBuzzControllerTests
    {
        Models.IModel mockModel;
        FizzBuzzController testController;

        [SetUp]
        public void Setup()
        {
            mockModel = new MockModel();
            testController = new FizzBuzzController(mockModel);
        }
        
        [Test]
        public void When_CallingGet_WithoutContent_ShouldGetFailureMessage()
        {
            var getFailed = false;
            try
            {
                testController.Post(null);
            } 
            catch(ArgumentException)
            {
                getFailed = true;
            }
            Assert.IsTrue(getFailed);
        }
        [Test]
        public void JSON_Test()
        {
            var json = "{\"Maximum\": \"100\",\"Triggers\": [{\"Multiple\": 3,\"Word\": \"Fizz\"   },{\"Multiple\": 5,\"Word\": \"Buzz\"}]}\"";

            var obj =  json.ParseJson();
            Assert.Equals("a", "b");
        }
    }
}