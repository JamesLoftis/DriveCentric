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

        public static RequestDto ParseJson(this string content)
        {
            var RequestDto = new RequestDto();
            try
            {
                RequestDto = JsonSerializer.Deserialize<RequestDto>(content);
            }
            catch(Exception ex)
            {
                RequestDto.Error = "Error Parsing JSON: " + ex.Message;
            }
            return RequestDto;
        }

        public static bool HasErrors(this RequestDto contentDto)
        {
            return !string.IsNullOrEmpty(contentDto.Error);
        }

        public static bool IsEqualTo(this RequestDto firstDto, RequestDto secondDto)
        {
            return firstDto.Maximum == secondDto.Maximum &&
                   firstDto.Error == secondDto.Error &&
                   firstDto.Triggers.IsEqualTo(secondDto.Triggers);
        }

        public static bool IsEqualTo(this TriggerDto[] firstCollection, TriggerDto[] secondCollection)
        {
            var equal = false;
            if(firstCollection.Length == secondCollection.Length)
            {
                equal = true;
                for(var i = 0; i < firstCollection.Length; i++)
                {
                    var firstTrigger = firstCollection[i];
                    var secondTrigger = secondCollection[i];
                    if(!firstTrigger.IsEqualTo(secondTrigger))
                    {
                        equal = false;
                        break;
                    }
                }
            }
            return equal;
        }

        public static bool IsEqualTo(this TriggerDto firstTrigger, TriggerDto secondTrigger)
        {
            return firstTrigger.Multiple == secondTrigger.Multiple && firstTrigger.Word == secondTrigger.Word;
        }
    }
}
