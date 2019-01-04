using Newtonsoft.Json;

namespace MessageCardModel.Actions.ActionCard
{
    public class TextInput : Input
    {
        /// <summary>
        /// Indicates whether the text input should accept multiple lines of text
        /// </summary>
        [JsonProperty("isMultiline")]
        public bool Multiline { get; set; }
        
        /// <summary>
        /// Indicates the maximum number of characters that can be entered
        /// </summary>
        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }
    }
}