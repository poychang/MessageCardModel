using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageCardModel.Actions
{
    public interface IAction
    {
        [JsonConverter(typeof(StringEnumConverter))]
        ActionType Type { get; set; }
        string Name { get; set; }
    }
}