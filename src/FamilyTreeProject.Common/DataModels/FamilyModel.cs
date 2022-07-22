using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class FamilyModel : AncestorModel
    {
        /// <summary>
        ///   Gets or sets a reference to this family's husband.
        /// </summary>
        [JsonProperty("husband")]
        public string Husband { get; set; }

        /// <summary>
        ///   Gets or sets a reference to this family's wife.
        /// </summary>
        [JsonProperty("wife")]
        public string Wife { get; set; }
    }
}