using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzz.Helpers;
using FizzBuzz.Dto;
using Newtonsoft.Json.Linq;

namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        const int MINIMUM = 1;
        public IEnumerable<string> CreateFizzBuzzCollection(RequestDto dto)
        {
            List<string> returnList;
            
            if(dto.Maximum.IsNotValidMaximum())
            {
                returnList = GetErrorList("Maximum value is not valid");
            }
            else if(dto.Triggers.ContainInvalidTriggerValues())
            {
                returnList = GetErrorList("One ore more multiplier are invalid");
            }
            else
            {
                returnList = GetListOfProperStrings(dto);
            }
            
            return returnList;
        }

        private List<string> GetErrorList(string error)
        {
            return new List<string> {error};
        }

        private List<string> GetListOfProperStrings(RequestDto requestDto)
        {
            var returnList = new List<string>();
            
            for(var current = MINIMUM; current <= requestDto.Maximum; current++)
            {
                returnList.Add(GetProperString(current, requestDto.Triggers));
            }
            return returnList;
        }

        private string GetProperString(int number, TriggerDto[] triggers)
        {
            string returnString = "";
            foreach(var trigger in triggers ?? new TriggerDto[0])
            {
                if(number.IsMultipleOf(trigger.Multiple))
                {
                    returnString = returnString += trigger.Word;
                }
            }
            return string.IsNullOrEmpty(returnString) ? number.ToString() : returnString;
        }
    }
}
