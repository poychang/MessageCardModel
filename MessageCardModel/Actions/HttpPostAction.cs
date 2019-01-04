using System.Collections.Generic;
using MessageCardModel.Actions.HttpPost;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageCardModel.Actions
{
    public class HttpPostAction : BaseAction, IEmbeddableAction
    {
        /// <summary>
        /// The name property defines the text that will be displayed on screen
        /// for the action.
        /// </summary>
        /// <remarks>
        /// Do use verbs. For instance, use "Set due date"
        /// instead of "Due date" or "Add note" instead of "Note". In some
        /// cases, the noun itself just works because it is also a verb: "Comment"
        /// </remarks>
        [JsonProperty("name")]
        public new string Name { get; set; }
        
        /// <summary>
        /// Defines the URL endpoint of the service that implements the action.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }
        
        /// <summary>
        /// A collection of <see cref="Header"/> objects representing a set of
        /// HTTP headers that will be emitted when sending the POST request
        /// to the target URL.
        /// </summary>
        [JsonProperty("headers")]
        public IEnumerable<Header> Headers { get; set; }
        
        /// <summary>
        /// The body of the POST request.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Optional and specifies the MIME type of the body in the POST request.
        /// Some services require that a content type be specified.
        /// Valid values are application/json and application/x-www-form-urlencoded.
        /// If not specified, application/json is assumed.
        /// </summary>
        [JsonProperty("bodyContentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BodyContentType BodyContentType { get; set; } = BodyContentType.Json;
    }
}