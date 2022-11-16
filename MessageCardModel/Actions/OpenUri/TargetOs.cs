using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.OpenUri
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TargetOs
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "windows")]
        Windows,
        [EnumMember(Value = "iOS")]
        iOS,
        [EnumMember(Value = "android")]
        Android,
    }
}