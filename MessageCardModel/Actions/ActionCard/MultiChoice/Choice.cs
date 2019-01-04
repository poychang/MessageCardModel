using Newtonsoft.Json;

namespace MessageCardModel.Actions.ActionCard.MultiChoice
{
    public class Choice
    {
        [JsonProperty("display")]
        public string Display { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}