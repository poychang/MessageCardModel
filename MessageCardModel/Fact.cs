using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace MessageCardModel
{
    public class Fact
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public static class FactHelper
    {
        public static IEnumerable<Fact> ToFact(this IDictionary<string, string> source) =>
            source.Select(element => new Fact { Name = element.Key, Value = element.Value }).ToList();
    }
}
