using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class IndividualModel : AncestorModel
    {
        /// <summary>
        ///   Gets or sets a reference to this individual's father.
        /// </summary>
        [JsonProperty("father")]
        public string Father { get; set; }

        /// <summary>
        ///   Gets or sets the first name of the individual
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///   Gets or sets the last name of the individual
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///   Gets or sets a reference to this individual's mother.
        /// </summary>
        [JsonProperty("mother")]
        public string Mother { get; set; }

        /// <summary>
        ///   Gets or sets the Sex of this individual
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }        
    }
}