// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ExecutionSettingsValues
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionSettingsValues class.
        /// </summary>
        public ExecutionSettingsValues()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionSettingsValues class.
        /// </summary>
        public ExecutionSettingsValues(IDictionary<string, object> dynamicProperties = default(IDictionary<string, object>))
        {
            DynamicProperties = dynamicProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DynamicProperties")]
        public IDictionary<string, object> DynamicProperties { get; set; }

    }
}