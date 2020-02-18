using Newtonsoft.Json;

namespace MessageCardModel
{
    public class Image
    {
        [JsonProperty("image")]
        public string Uri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
