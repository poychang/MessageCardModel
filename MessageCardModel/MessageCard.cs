using System.Collections.Generic;
using MessageCardModel.Actions;
using Newtonsoft.Json;

namespace MessageCardModel
{
    public class MessageCard
    {
        [JsonProperty("@type")]
        public const string Type = "MessageCard";
        
        [JsonProperty("@context")]
        public const string Context = "http://schema.org/extensions";
        
        [JsonProperty("summary")]
        public string Summary { get; set; }
        
        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("sections")]
        public IEnumerable<Section> Sections { get; set; }
        
        [JsonProperty("potentialAction")]
        public IEnumerable<IAction> Actions { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}