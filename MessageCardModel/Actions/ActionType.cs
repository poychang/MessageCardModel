using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MessageCardModel.Actions
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionType
    {
        [EnumMember(Value = "ActionCard")]
        ActionCard,
        [EnumMember(Value = "HttpPOST")]
        HttpPost,
        [EnumMember(Value = "OpenUri")]
        OpenUri
    }
}
