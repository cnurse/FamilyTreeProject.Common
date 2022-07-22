using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class RepositoryModel : EntityModel
    {
        /// <summary>
        /// The Address of the Repository
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The Name of the Repository
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}