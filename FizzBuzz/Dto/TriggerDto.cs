using Newtonsoft.Json;

namespace FizzBuzz.Dto
{
    public class TriggerDto
    {
        [JsonProperty]
        public int Multiple {get;set;}
        
        [JsonProperty]
        public string Word {get;set;}
    }
}
