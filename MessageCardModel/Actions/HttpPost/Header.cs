using Newtonsoft.Json;

namespace MessageCardModel.Actions.HttpPost
{
    public class Header
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}