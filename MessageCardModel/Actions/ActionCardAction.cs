using System.Collections.Generic;
using MessageCardModel.Actions.ActionCard;
using Newtonsoft.Json;

namespace MessageCardModel.Actions
{
    public class ActionCardAction : BaseAction
    {
        [JsonProperty("inputs")]
        public IEnumerable<Input> Inputs { get; set; }
        
        [JsonProperty("actions")]
        public IEnumerable<IEmbeddableAction> Actions { get; set; }
    }
}