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

        public static bool HasErrors(this RequestDto contentDto)
        {
            return !string.IsNullOrEmpty(contentDto.Error);
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
