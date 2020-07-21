using System.Text.Json.Serialization;

namespace MessageCardModel.Actions
{
    public interface IAction
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        ActionType Type { get; set; }
        string Name { get; set; }
    }
}
