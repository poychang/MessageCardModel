using Newtonsoft.Json;
using System.Collections.Generic;

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

        [JsonProperty("activityText")]
        public string ActivityText { get; set; }

        [JsonProperty("activityImage")]
        public string ActivityImage { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("facts")]
        public IEnumerable<Fact> Facts { get; set; }
    }
}