using System.Runtime.Serialization;

namespace MessageCardModel.Actions
{
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
