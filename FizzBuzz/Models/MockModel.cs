using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Models;

namespace FizzBuzz.Tests
{
    public class MockModel : IModel
    {
        public IEnumerable<string>  CreateFizzBuzzCollection(string content)
        {
            return new List<string>();
        }
    }
}
