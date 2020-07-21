using System.Text.Json.Serialization;

namespace MessageCardModel
{
    public class Image
    {
        [JsonPropertyName("image")]
        public string Uri { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
