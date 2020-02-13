using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace FizzBuzz.Dto
{
    public class RequestDto
    {
        [JsonProperty("Maximum")]
        public string Maximum {get;set;}
        
        [JsonProperty("Triggers")]
        public Trig[] Triggers{get;set;}

        public string Error {get;set;}
    }
    public class Trigger
    {
        [JsonProperty("Multiple")]
        public int Multiple {get;set;}
        
        [JsonProperty("Word")]
        public string Word {get;set;}
    }
}
