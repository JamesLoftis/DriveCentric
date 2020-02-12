using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzz.Dto
{
    public class TriggerDto
    {
        public int Multiple {get;set;}
        
        public string Word {get;set;}
    }
    public class TriggersCol 
    {
        [JsonProperty("Triggers")]
        List<TriggerRequestDto> Triggers{get;set;}
    }
    public class TriggerRequestDto
    {
        [JsonProperty("Multiple")]
        public int Multiple {get;set;}
        
        [JsonProperty("Word")]
        public string Word {get;set;}
    }
}
