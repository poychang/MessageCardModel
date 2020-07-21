using System.Text.Json.Serialization;
using MessageCardModel.Actions;

namespace MessageCardModel
{
    public class BaseAction : IAction
    {
        [JsonPropertyName("@type")]
        public ActionType Type { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
