using System.Collections.Generic;
using System.Text.Json.Serialization;
using MessageCardModel.Actions.OpenUri;

namespace MessageCardModel.Actions
{
    public class OpenUriAction : BaseAction, IEmbeddableAction
    {
        [JsonPropertyName("targets")]
        public IEnumerable<Target> Targets { get; set; }
    }
}
