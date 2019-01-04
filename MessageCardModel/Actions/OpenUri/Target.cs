using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageCardModel.Actions.OpenUri
{
    public class Target
    {
        [JsonProperty("os")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TargetOs OS { get; set; } = TargetOs.Default;
        
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}