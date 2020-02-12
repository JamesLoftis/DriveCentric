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
            var ResponseDto = content.ParseJson();
            List<string> returnList;
            
            if(ResponseDto.HasErrors())
            {
                returnList = GetErrorList("Errors occurred parsing JSON");
            } 
            // else if(ResponseDto.Maximum.IsNotValid())
            // {
            //     returnList = GetErrorList("Maximum value is not valid");
            // }
            else
            {
                returnList = GetListOfProperStrings(ResponseDto);
            }
            
            return returnList;
        }

        private List<string> GetErrorList(string error)
        {
            return new List<string> {error};
        }

        private List<string> GetListOfProperStrings(ResponseDto ResponseDto)
        {
            var returnList = new List<string>();
            
            for(var current = MINIMUM; current <= ResponseDto.Maximum; current++)
            {
                returnList.Add(GetProperString(current, ResponseDto.TriggerDtoCollection));
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
