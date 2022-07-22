using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class EntityModel : UniqueModel
    {
        /// <summary>
        /// The Id of the Tree to which this entity belongs
        /// </summary>
        [JsonProperty("treeId")]
        public string TreeId { get; set; }
        
    }
}