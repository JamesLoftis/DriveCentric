using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        public static FizzBuzz GetFizzBuzz()
        {
            var output = new FizzBuzz("FIZZBUZZ");
            return output;
        }
    }
}
