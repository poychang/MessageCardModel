using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.OpenUri
{
    public class Target
    {
        [JsonPropertyName("os")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TargetOs OS { get; set; } = TargetOs.Default;
        
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
