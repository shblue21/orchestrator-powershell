// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SpecificPackageParameters
    {
        /// <summary>
        /// Initializes a new instance of the SpecificPackageParameters class.
        /// </summary>
        public SpecificPackageParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpecificPackageParameters class.
        /// </summary>
        public SpecificPackageParameters(string packageVersion = default(string))
        {
            PackageVersion = packageVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }

    }
}