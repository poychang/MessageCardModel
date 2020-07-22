using MessageCardModel.Actions;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MessageCardModel
{
    public class MessageCard
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; } = "MessageCard";

        [JsonPropertyName("@context")]
        public string Context { get; set; } = "http://schema.org/extensions";

        [JsonPropertyName("originator")]
        public string Originator { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("themeColor")]
        public string ThemeColor { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("sections")]
        public IEnumerable<Section> Sections { get; set; }

        [JsonPropertyName("potentialAction")]
        public IEnumerable<IAction> Actions { get; set; }

        public string ToJson()
        {
            var option = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            return JsonSerializer.Serialize(this, option);
        }
    }
}
