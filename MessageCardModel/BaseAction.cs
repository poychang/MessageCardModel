using MessageCardModel.Actions;
using Newtonsoft.Json;

namespace MessageCardModel
{
    public class BaseAction : IAction
    {
        [JsonProperty("@type")]
        public ActionType Type { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}