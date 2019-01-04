using System.Runtime.Serialization;

namespace MessageCardModel.Actions.HttpPost
{
    public enum BodyContentType
    {
        [EnumMember(Value = "application/json")] 
        Json,
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        FormEncoded
    }
}