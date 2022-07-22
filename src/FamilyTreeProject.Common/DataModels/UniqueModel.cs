using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class UniqueModel : BaseModel
    {
        /// <summary>
        /// A Globally Unique Identifier for the Entity
        /// </summary>
        [JsonProperty("id")]
        public string UniqueId { get; set; }
    }
}