using System.Collections.Generic;
using System.Text.Json.Serialization;
using MessageCardModel.Actions.ActionCard.MultiChoice;

namespace MessageCardModel.Actions.ActionCard
{
    public class MultiChoiceInput : Input
    {
        /// <summary>
        /// Defines the values that can be selected for the multi choice input.
        /// </summary>
        [JsonPropertyName("choices")]
        public IEnumerable<Choice> Choices { get; set; }

        /// <summary>
        /// If set to true, indicates that the user can select more than one
        /// choice. The specified choices will be displayed as a list of
        /// checkboxes.
        /// 
        /// Default value is false.
        /// </summary>
        [JsonPropertyName("isMultiSelect")]
        public bool MultiSelect { get; set; }

        [JsonPropertyName("style")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Style Style { get; set; } = Style.Normal;
    }
}
