using System.Collections.Generic;
using MessageCardModel.Actions.ActionCard.MultiChoice;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageCardModel.Actions.ActionCard
{
    public class MultiChoiceInput : Input
    {
        /// <summary>
        /// Defines the values that can be selected for the multi choice input.
        /// </summary>
        [JsonProperty("choices")]
        public IEnumerable<Choice> Choices { get; set; }

        /// <summary>
        /// If set to true, indicates that the user can select more than one
        /// choice. The specified choices will be displayed as a list of
        /// checkboxes.
        /// 
        /// Default value is false.
        /// </summary>
        [JsonProperty("isMultiSelect")]
        public bool MultiSelect { get; set; }

        [JsonProperty("style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Style Style { get; set; } = Style.Normal;
    }
}