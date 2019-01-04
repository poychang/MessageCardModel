using System.Collections.Generic;
using MessageCardModel.Actions.OpenUri;
using Newtonsoft.Json;

namespace MessageCardModel.Actions
{
    public class OpenUriAction : BaseAction, IEmbeddableAction
    {
        [JsonProperty("targets")]
        public IEnumerable<Target> Targets { get; set; }
    }
}