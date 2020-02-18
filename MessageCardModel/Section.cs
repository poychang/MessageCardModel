using MessageCardModel.Actions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MessageCardModel
{
    public class Section
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("startGroup")]
        public bool IsStartGroup { get; set; } = false;

        [JsonProperty("activityTitle")]
        public string ActivityTitle { get; set; }

        [JsonProperty("activitySubtitle")]
        public string ActivitySubtitle { get; set; }

        [JsonProperty("activityText")]
        public string ActivityText { get; set; }

        [JsonProperty("activityImage")]
        public string ActivityImage { get; set; }

        [JsonProperty("heroImage")]
        public Image HeroImage { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("facts")]
        public IEnumerable<Fact> Facts { get; set; }

        [JsonProperty("images")]
        public IEnumerable<Image> Images { get; set; }

        [JsonProperty("potentialAction")]
        public IEnumerable<IAction> Actions { get; set; }
    }
}