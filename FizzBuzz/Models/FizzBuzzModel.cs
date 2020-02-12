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
        IEnumerable<TriggerDto> triggerCollection;
        const int MINIMUM = 1;
        public IEnumerable<string> CreateFizzBuzzCollection(string content)
        {
            var RequestDto = content.ParseJson();
            List<string> returnList;
            
            if(RequestDto.HasErrors())
            {
                returnList = GetErrorList("Errors occurred parsing JSON");
            } 
            else if(RequestDto.Maximum.IsNotValid())
            {
                returnList = GetErrorList("Maximum value is not valid");
            }
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

        private List<string> GetListOfProperStrings(RequestDto RequestDto)
        {
            var returnList = new List<string>();
            
            for(var current = MINIMUM; current <= RequestDto.Maximum; current++)
            {
                returnList.Add(GetProperString(current, RequestDto.TriggerDtoCollection));
            }
            return returnList;
        }

        private string GetProperString(int number, IEnumerable<TriggerDto> triggerCollection)
        {
            string returnString = "";
            foreach(var trigger in triggerCollection)
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
