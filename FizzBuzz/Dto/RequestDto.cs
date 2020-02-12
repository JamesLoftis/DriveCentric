using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FizzBuzz.Dto
{
    public class ResponseDto
    {
        public ResponseDto()
        {
            TriggerDtoCollection = new List<TriggerDto>();
        }

        public int Maximum {get;set;}
        
        public List<TriggerDto> TriggerDtoCollection{get;set;}

        public string Error {get;set;}
    }

    public class RequestDto
    {
        [JsonProperty("Maximum")]
        public string Maximum {get;set;}
        
        [JsonProperty("Triggers")]
        public TriggersCol Triggers{get;set;}

        public string Error {get;set;}
    }
}
