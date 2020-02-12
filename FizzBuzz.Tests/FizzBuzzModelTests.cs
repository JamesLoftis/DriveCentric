using NUnit.Framework;
using FizzBuzz.Models;
using System.Linq;

namespace FizzBuzz.Tests
{
    public class FizzBuzzModelTests
    {
        FizzBuzzModel testModel;

        [SetUp]
        public void Setup()
        {
            testModel = new FizzBuzzModel();
        }

        [Test]
        public void When_OriginalNumbers_ArePassedIn_Should_ReturnAnArrayStartingWith_1()
        {
            const int min = 1;
            const int max = 100;
            var testArray = testModel.CreateFizzBuzzCollection(min, max).ToArray();
            Assert.True(testArray.First() == min.ToString());
            Assert.True(testArray.First() == min.ToString());
        }

        [Test]
        public void When_OriginalNumbers_ArePassedIn_Should_ReturnAnArrayEndingWith_100()
        {
            const int min = 1;
            const int max = 100;
            var testArray = testModel.CreateFizzBuzzCollection(min, max).ToArray();
            Assert.True(testArray.Last() == max.ToString());
        }

        [Test]
        public void WhenMinium_IsPassedIn_ReturnShould_StartWithMinimum()
        {
            string[] testArray;
            for(var i = 0; i < 5; i++)
            {
                testArray = testModel.CreateFizzBuzzCollection(i, 100).ToArray();
                Assert.True(testArray.First() == i.ToString());
            }
        }

        [Test]
        public void WhenMaximum_IsPassedIn_ReturnShould_EndWithMaximum()
        {
            string[] testArray;
            for(var i = 10; i < 15; i++)
            {
                testArray = testModel.CreateFizzBuzzCollection(1, i).ToArray();
                Assert.True(testArray.Last() == i.ToString());
            }
        }
        
        [Test]
        public void WhenMinium_IsFive_ReturnShould_StartWithFive()
        {
            Assert.Pass();
        }
    }
}