using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Helpers
{
    public static class FizzBuzzHelpers
    {
        public static bool IsValid(this int? candidate)
        {
            return candidate != null && candidate > 0;
        }

        public static bool IsMultipleOf(this int number, int multiple)
        {
            return number % multiple == 0;
        }
    }
}
