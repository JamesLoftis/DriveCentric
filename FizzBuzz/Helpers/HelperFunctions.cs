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
        public static bool IsNotValid(this int candidate)
        {
            return candidate <= 0;
        }

        public static bool IsMultipleOf(this int number, int multiple)
        {
            return number % multiple == 0;
        }

        public static bool AreNotValid(this TriggerDto[] triggers)
        {
            return triggers.Any(x => x.multiple == 0 || x.multiple == null);
        }
    }
}
