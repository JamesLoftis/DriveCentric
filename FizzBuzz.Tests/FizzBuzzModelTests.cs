using NUnit.Framework;
using FizzBuzz.Models;
using FizzBuzz.Dto;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class FizzBuzzModelTests
    {
        FizzBuzzModel testModel;
        RequestDto testRequest;

        [SetUp]
        public void Setup()
        {
            testModel = new FizzBuzzModel();
            testRequest = new RequestDto();
            testRequest.Maximum = 100;
            testRequest.Triggers = new List<Trigger>();
        }

        [Test]
        public void When_AnythingIsPassedIn_Should_ReturnAnArrayStartingWith_1()
        {
            const string min = "1";
            var json = JsonConvert.SerializeObject(testRequest);
            var testArray = testModel.CreateFizzBuzzCollection(json).ToArray();
            Assert.True(testArray.First() == min, testArray.First() ?? "");
        }

        [Test]
        public void When_OriginalNumbers_ArePassedIn_Should_ReturnAnArrayEndingWith_100()
        {
            const int max = 100;
            testRequest.Maximum = max;
            var json = JsonConvert.SerializeObject(testRequest);
            var testArray = testModel.CreateFizzBuzzCollection(json).ToArray();
            Assert.True(testArray.Last() == max.ToString(), testArray.First() ?? "");
        }

        [Test]
        public void WhenMaximum_IsPassedIn_ReturnShould_EndWithMaximum()
        {
            for(var i = 1; i < 5; i++)
            {
                testRequest.Maximum = i;
                var json = JsonConvert.SerializeObject(testRequest);
                var testArray = testModel.CreateFizzBuzzCollection(json).ToArray();
                Assert.True(testArray.Last() == i.ToString(), testArray.Last() ?? "");
            }
        }
    }
}