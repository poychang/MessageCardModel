using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MessageCardModel
{
    public class Fact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public static class FactHelper
    {
        public static IEnumerable<Fact> ToFact(this IDictionary<string, string> source) =>
            source.Select(element => new Fact { Name = element.Key, Value = element.Value }).ToList();
    }
}