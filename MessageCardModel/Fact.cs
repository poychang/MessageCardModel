using Newtonsoft.Json;

namespace MessageCardModel
{
    public class Fact
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}