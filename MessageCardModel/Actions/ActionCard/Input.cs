using System.Text.Json.Serialization;

namespace MessageCardModel.Actions.ActionCard
{
    public class Input
    {
        /// <summary>
        /// Uniquely identifies the input so it is possible to reference it in
        /// the URL or body of an <see cref="HttpPostAction" /> action.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Indicates whether users are required to type a value before they
        /// are able to take an action that would take the value of the input
        /// as a parameter.
        /// </summary>
        [JsonPropertyName("isRequired")]
        public bool Required { get; set; }
        
        /// <summary>
        /// Defines a title for the input.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        /// <summary>
        /// Defines the initial value of the input.
        /// For multi-choice inputs, value must be equal to the value
        /// property of one of the input's choices.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
