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
        const int MIN = 1;
        const int MAX = 100;

        public FizzBuzzModelTests()
        {
            testModel = new FizzBuzzModel();
            testRequest = new RequestDto();
        }
        
        [Test]
        public void When_AnythingIsPassedIn_Should_ReturnAnArrayStartingWith_1()
        {
            testRequest.Maximum = MAX;
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray.First() == MIN.ToString());
        }

        [Test]
        public void When_OriginalNumbers_ArePassedIn_Should_ReturnAnArrayEndingWith_100()
        {
            testRequest.Maximum = MAX;
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray.Last() == MAX.ToString());
        }

        [Test]
        public void WhenMaximum_IsPassedIn_ReturnShould_EndWithMaximum()
        {
            for(var i = 1; i < 5; i++)
            {
                testRequest.Maximum = i;
                var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
                Assert.True(testArray.Last() == i.ToString());
            }
        }

        [Test]
        public void When_TriggerIs5_Then_EveryFifth_IsWord()
        {
            testRequest.Maximum = 10;
            testRequest.Triggers = new TriggerDto[]
            {
                new TriggerDto{Multiple=5, Word="Test"}
            };
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray[4] == "Test", testArray[4]);
            Assert.True(testArray[9] == "Test", testArray[9]);
        }

        [Test]
        public void When_TriggerIs5_And_10_Then_5_IsWord1_And_10_IsWord1And2()
        {
            testRequest.Maximum = 10;
            testRequest.Triggers = new TriggerDto[]
            {
                new TriggerDto{Multiple=5, Word="Test"},
                new TriggerDto{Multiple=10, Word="Foo"}
            };
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            Assert.True(testArray[4] == "Test", testArray[4]);
            Assert.True(testArray[9] == "TestFoo", testArray[9]);
        }

        [Test]
        public void When_ThreeTriggers_AreUsed_ShouldCombineCorrectly()
        {
            testRequest.Maximum = 10;
            testRequest.Triggers = new TriggerDto[]
            {
                new TriggerDto{Multiple=2, Word="Bozz"},
                new TriggerDto{Multiple=5, Word="Test"},
                new TriggerDto{Multiple=10, Word="Foo"}
            };
            var testArray = testModel.CreateFizzBuzzCollection(testRequest).ToArray();
            var resultString = string.Join("",testArray);
            Assert.True(resultString == "1Bozz3BozzTestBozz7Bozz9BozzTestFoo", resultString);
        }
    }
}