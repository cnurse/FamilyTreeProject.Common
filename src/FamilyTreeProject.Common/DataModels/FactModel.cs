using System.Collections.Generic;
using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class FactModel : BaseModel
    {
        /// <summary>
        ///   Gets or sets the Citations for the Fact
        /// </summary>
        [JsonProperty("citations")]
        public IList<CitationModel> Citations { get; set; }
        
        /// <summary>
        /// The date of the fact (if the fact is an event)
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// The type of the Fact
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The place for the fact
        /// </summary>
        [JsonProperty("place")]
        public string Place { get; set; }
    }
}