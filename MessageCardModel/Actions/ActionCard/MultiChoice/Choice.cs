using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.ActionCard.MultiChoice
{
    public class Choice
    {
        [JsonPropertyName("display")]
        public string Display { get; set; }
        
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
