using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Dto
{
    public class RequestDto
    {
        public RequestDto()
        {
            TriggerDtoCollection = new List<TriggerDto>();
        }
        [JsonProperty("maximum")] 
        public int? Maximum {get;set;}
        
        [JsonProperty("triggers")]
        public List<TriggerDto> TriggerDtoCollection{get;set;}

        public string Error {get;set;}
    }
}
