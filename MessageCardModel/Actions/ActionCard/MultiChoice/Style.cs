using System.Runtime.Serialization;

namespace MessageCardModel.Actions.ActionCard.MultiChoice
{
    public enum Style
    {
        [EnumMember(Value = "normal")]
        Normal,
        
        [EnumMember(Value = "expanded")]
        Expanded
    }
}