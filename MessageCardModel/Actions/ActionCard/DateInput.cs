using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.ActionCard
{
    public class DateInput : Input
    {
        /// <summary>
        /// Indicates whether the date input should allow for the selection of
        /// a time in addition to the date.
        /// </summary>
        [JsonPropertyName("includeTime")]
        public bool IncludeTime { get; set; }
    }
}
