using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FizzBuzz.Dto;

namespace FizzBuzz.Helpers
{
    public static class FizzBuzzHelpers
    {
        public static bool IsNotValid(this int? candidate)
        {
            return candidate == null || candidate <= 0;
        }

        public static bool IsMultipleOf(this int number, int multiple)
        {
            return number % multiple == 0;
        }

        public static RequestDto ParseJson(this string content)
        {
            var RequestDto = new RequestDto();
            try
            {
                RequestDto = JsonConvert.DeserializeObject<RequestDto>(content);
            }
            catch(Exception ex)
            {
                RequestDto.Error = ex.Message;
            }
            return RequestDto;
        }

        public static bool HasErrors(this RequestDto contentDto)
        {
            return !string.IsNullOrEmpty(contentDto.Error);
        }
    }
}
