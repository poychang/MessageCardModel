using MessageCardModel.Actions;
using System;
using System.Collections.Generic;
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
                Converters = { new JsonStringEnumConverter() },
                //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            option.Converters.Add(new ActionConverter());
            return JsonSerializer.Serialize(this, option);
        }
    }

    internal class ActionConverter : JsonConverter<IAction>
    {
        public override IAction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
        public override void Write(Utf8JsonWriter writer, IAction value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ActionCardAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;
                case HttpPostAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;
                case OpenUriAction action:
                    JsonSerializer.Serialize(writer, action, options);
                    break;
                default:
                    throw new ArgumentException("It is not a recognized type.", nameof(value));
            }
        }
    }
}
