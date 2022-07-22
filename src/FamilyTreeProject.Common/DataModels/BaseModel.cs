using System.Collections.Generic;
using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
            Notes = new List<NoteModel>();
        }
        
        /// <summary>
        ///   Gets or sets the id of the Entity
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }
        
        /// <summary>
        ///Gets or sets the type of entity
        /// </summary>
        [JsonProperty("entityType")]
        public string EntityType { get; set; }
        
        /// <summary>
        /// A list of Notes
        /// </summary>
        [JsonProperty("notes")]
        public IList<NoteModel> Notes { get; set; }
    }
}