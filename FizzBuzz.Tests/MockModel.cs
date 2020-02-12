using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Models;
using FizzBuzz.Trigger;

namespace FizzBuzz.Tests
{
    public class MockModel : IModel
    {
        public IEnumerable<string>  CreateFizzBuzzCollection(int minimum, int maximum, TriggerCollection triggers)
        {
            return new List<string>();
        }
    }
}
