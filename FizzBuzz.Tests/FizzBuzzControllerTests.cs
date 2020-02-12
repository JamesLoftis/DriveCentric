using NUnit.Framework;
using FizzBuzz.Controllers;
using FizzBuzz;
using System.Linq;
using System;

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
        public void When_CallingGet_WithoutMinimum_ShouldFail()
        {
            var getFailed = false;
            try
            {
                testController.Get(null);
            } 
            catch(ArgumentException)
            {
                getFailed = true;
            }
            Assert.IsTrue(getFailed);
        }

        [Test]
        public void When_CallingGet_WithMinimumLessThanOne_ShouldFail()
        {
            var getFailed = false;
            try
            {
                testController.Get(-1);
            } 
            catch(ArgumentException)
            {
                getFailed = true;
            }
            Assert.IsTrue(getFailed);
        }

        [Test]
        public void When_CallingGet_WithMinimumEqualToOne_ShouldPass()
        {
            var getFailed = false;
            try
            {
                testController.Get(1);
            } 
            catch(ArgumentException)
            {
                getFailed = true;
            }
            Assert.IsFalse(getFailed);
        }

        [Test]
        public void When_CallingGet_WithMinimumGreaterThanOne_ShouldPass()
        {
            var getFailed = false;
            try
            {
                testController.Get(2);
            } 
            catch(ArgumentException)
            {
                getFailed = true;
            }
            Assert.IsFalse(getFailed);
        }
    }
}