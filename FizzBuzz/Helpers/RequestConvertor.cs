using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FizzBuzz.Dto;

namespace FizzBuzz.Helpers
{
    internal class RequestConvertor : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new System.NotImplementedException();
    }

    public override bool CanConvert(Type objectType)
    {
        return typeof (PagedList<User>).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.StartObject)
        {
            JObject item = JObject.Load(reader);
            
            if (item["triggers"] != null)
            {
                var triggers = item["triggers"].ToObject<IList<TriggerDto>>(serializer);
                var multiple = item["multiple"].Value<string>();
                int word = item["word"].Value<string>();
                return new RequestDto(users, new Trigger(start, limit, length, total));
            }
        }
        else
        {
            JArray array = JArray.Load(reader);

            var users = array.ToObject<IList<TriggerDto>>();

            return new RequestDto()
        }

        // This should not happen. Perhaps better to throw exception at this point?
        return null;
    }
}
}