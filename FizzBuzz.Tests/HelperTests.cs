using NUnit.Framework;
using FizzBuzz.Helpers;
using FizzBuzz.Dto;

namespace FizzBuzz.Tests
{
    public class HelperTests
    {
        [Test]
        public void When_TestingValidityofInt_Zero_Shouldreturn_True()
        {
            var test = 0;
            Assert.IsTrue(test.IsNotValidMaximum());
        }
        [Test]
        public void When_TestingValidityofInt_NegativeNumbers_Shouldreturn_True()
        {
            var test = -100;
            Assert.IsTrue(test.IsNotValidMaximum());
        }
        [Test]
        public void When_TestingValidityofInt_ExactlyOne_Shouldreturn_False()
        {
            var test = 1;
            Assert.IsFalse(test.IsNotValidMaximum());
        }
        [Test]
        public void When_TestingValidityofInt_GreaterThanOne_Shouldreturn_False()
        {
            var test = 100;
            Assert.IsFalse(test.IsNotValidMaximum());
        }

        [Test]
        public void When_TestingingMultipleValues_WithMultipleOf_0_ShouldReturn_False()
        {
            var firstNumber = 100;
            var secondNumber = 0;
            Assert.IsFalse(firstNumber.IsMultipleOf(secondNumber));
        }
        
        [Test]
        public void When_TestingingMultipleValue_WhereIsNOTMultiple_ShouldReturn_True()
        {
            var firstNumber = 100;
            var secondNumber = 1;
            Assert.IsTrue(firstNumber.IsMultipleOf(secondNumber));
        }

        [Test]
        public void When_TestingingMultipleValue_WhereIsMultiple_ShouldReturn_True()
        {
            var firstNumber = 1;
            var secondNumber = 10;
            Assert.IsFalse(firstNumber.IsMultipleOf(secondNumber));
        }

        [Test]
        public void When_TestingTriggerValues_WithMultipleSetTo_Zero_ShouldReturn_True()
        {
            var testTriggers = new TriggerDto[]{
                new TriggerDto(){Multiple=0, Word="Test"},
                new TriggerDto(){Multiple=5, Word="Test2"}
            };
            Assert.IsTrue(testTriggers.ContainInvalidTriggerValues());
        }

        [Test]
        public void When_TestingTriggerValues_WithMultipleNotSet_ShouldReturn_True()
        {
            var testTriggers = new TriggerDto[]{
                new TriggerDto(){Word="Test"},
                new TriggerDto(){Multiple=5, Word="Test2"}
            };
            Assert.IsTrue(testTriggers.ContainInvalidTriggerValues());
        }

        [Test]
        public void When_TestingTriggerValues_WithMultipleSetTo_ValidNumbers_ShouldReturn_False()
        {
            var testTriggers = new TriggerDto[]{
                new TriggerDto(){Multiple=1, Word="Test"},
                new TriggerDto(){Multiple=5, Word="Test2"}
            };
            Assert.IsFalse(testTriggers.ContainInvalidTriggerValues());
        }

        [Test]
        public void When_TestingTriggerValues_With_EmptyTriggerArray_ShouldReturn_True()
        {
            var testTriggers = new TriggerDto[5];
            Assert.IsTrue(testTriggers.ContainInvalidTriggerValues());
        }
    }
}