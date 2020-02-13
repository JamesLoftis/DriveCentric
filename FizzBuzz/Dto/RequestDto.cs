using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FizzBuzz.Dto
{
    public class RequestDto
    {
        [JsonProperty("Maximum")]
        public int Maximum {get;set;}
        
        [JsonProperty("Triggers")]
        public TriggerDto[] Triggers{get;set;}

        public string Error {get;set;}
    }
    public class TriggerDto
    {
        [JsonProperty("Multiple")]
        public int Multiple {get;set;}
        
        [JsonProperty("Word")]
        public string Word {get;set;}
    }
}
