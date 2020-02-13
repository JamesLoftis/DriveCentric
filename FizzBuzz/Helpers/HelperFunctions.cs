using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Dto;
using System.Text.Json;

namespace FizzBuzz.Helpers
{
    public static class Helpers
    {
        public static bool IsNotValidMaximum(this int candidate)
        {
            return candidate <= 0;
        }

        public static bool IsMultipleOf(this int number, int multiple)
        {
            return multiple != 0 && number % multiple == 0;
        }

        public static bool ContainInvalidTriggerValues(this TriggerDto[] triggers)
        {
            return triggers != null && triggers.Any(x => x == null || x.Multiple == null || x.Multiple == 0);
        }
    }
}
