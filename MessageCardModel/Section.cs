using System.Collections.Generic;
using Newtonsoft.Json;

namespace MessageCardModel
{
    public class Section
    {
        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("activityTitle")]
        public string ActivityTitle { get; set; }
        
        [JsonProperty("activitySubtitle")]
        public string ActivitySubtitle { get; set; }
        
        [JsonProperty("activityImage")]
        public string ActivityImage { get; set; }
        
        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("facts")]
        public IEnumerable<Fact> Facts { get; set; }
    }
}