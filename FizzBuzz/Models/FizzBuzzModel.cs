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
    public class FizzBuzzModel : IModel
    {
        const int MINIMUM = 1;
        public IEnumerable<string> CreateFizzBuzzCollection(string content)
        {
            var RequestDto = content.ParseJson();
            List<string> returnList;
            
            if(RequestDto.HasErrors())
            {
                returnList = GetErrorList("Errors occurred parsing JSON");
            } 
            // else if(RequestDto.Maximum.IsNotValid())
            // {
            //     returnList = GetErrorList("Maximum value is not valid");
            // }
            else
            {
                returnList = GetListOfProperStrings(RequestDto);
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

        private string GetProperString(int number, IEnumerable<TriggerDto> Triggers)
        {
            string returnString = "";
            foreach(var trigger in Triggers)
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
