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
        [JsonProperty] 
        public int? Maximum {get;set;}
        
        [JsonProperty]
        public IEnumerable<TriggerDto> TriggerDtoCollection{get;set;}

        public string Error {get;set;}
    }
}
