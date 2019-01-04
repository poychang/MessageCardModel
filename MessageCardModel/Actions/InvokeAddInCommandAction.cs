using System;
using Newtonsoft.Json;

namespace MessageCardModel.Actions
{
    public class InvokeAddInCommandAction : BaseAction
    {
        /// <summary>
        /// Specifies the add-in ID of the required add-in.
        /// The add-in ID is found in the Id element in the add-in's manifest.
        /// </summary>
        [JsonProperty("addInId")]
        public Guid AddInId { get; set; }
        
        /// <summary>
        /// Specifies the ID of the add-in command button that opens the
        /// required taskpane.The command button ID is found in the id attribute
        /// of the Control element that defines the button in the add-in's
        /// manifest. The specified Control element MUST be defined inside a
        /// MessageReadCommandSurface extension point, be of type Button, and
        /// the control's Action must be of type ShowTaskPane.
        /// </summary>
        [JsonProperty("desktopCommandId")]
        public string DesktopCommandId { get; set; }
        
        /// <summary>
        /// Optional. Developers may specify any valid JSON object in this
        /// field. The value is serialized into a string and made available to
        /// the add-in when the action is executed. This allows the action to
        /// pass initialization data to the add-in.
        /// </summary>
        [JsonProperty("initializationContext")]
        public object InitializationContext { get; set; }
    }
}