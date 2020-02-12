using Newtonsoft.Json;

namespace FizzBuzz.Dto
{
    public class TriggerDto
    {
        [JsonProperty("multiple")]
        public int Multiple {get;set;}
        
        [JsonProperty("word")]
        public string Word {get;set;}
    }
}
