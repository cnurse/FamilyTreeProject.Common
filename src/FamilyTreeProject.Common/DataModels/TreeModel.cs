using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class TreeModel : UniqueModel
    {
        /// <summary>
        /// The Description of the Tree
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The Name of the Tree
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Owner of the Tree
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }
        
        /// <summary>
        /// The Title of the Tree
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}