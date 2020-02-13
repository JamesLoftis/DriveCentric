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
        [Test]
        public void When_AnythingIsPassedIn_Should_ReturnAnArrayStartingWith_1()
        {
            const string min = "1";

            var testModel = new FizzBuzzModel();
            var testRequest = new RequestDto();
            testRequest.Maximum = 100;
            testRequest.Triggers = new TriggerDto[5];
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray.First() == min);
        }

        [Test]
        public void When_OriginalNumbers_ArePassedIn_Should_ReturnAnArrayEndingWith_100()
        {
                       var testModel = new FizzBuzzModel();
            const string min = "1";
            var testRequest = new RequestDto();
            testRequest.Maximum = 100;
            testRequest.Triggers = new TriggerDto[5];
            const int max = 100;
            testRequest.Maximum = max;
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray.Last() == max.ToString());
        }

        [Test]
        public void WhenMaximum_IsPassedIn_ReturnShould_EndWithMaximum()
        {
                       var testModel = new FizzBuzzModel();
            const string min = "1";
            var testRequest = new RequestDto();
            testRequest.Maximum = 100;
            testRequest.Triggers = new TriggerDto[5];
            for(var i = 1; i < 5; i++)
            {
                testRequest.Maximum = i;
                var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
                Assert.True(testArray.Last() == i.ToString());
            }
        }
    }
}