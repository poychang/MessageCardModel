using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.HttpPost
{
    public class Header
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
