using System.Collections.Generic;
using System.Text.Json.Serialization;
using MessageCardModel.Actions.ActionCard;

namespace MessageCardModel.Actions
{
    public class ActionCardAction : BaseAction
    {
        [JsonPropertyName("inputs")]
        public IEnumerable<Input> Inputs { get; set; }
        
        [JsonPropertyName("actions")]
        public IEnumerable<IEmbeddableAction> Actions { get; set; }
    }
}
