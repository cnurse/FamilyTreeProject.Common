using System.Collections.Generic;
using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public abstract class AncestorModel : EntityModel
    {
        protected AncestorModel()
        {
            Facts = new List<FactModel>();
        }
        
        /// <summary>
        ///   Gets or sets the Citations of the Ancestor (Individual/Family).
        /// </summary>
        [JsonProperty("citations")]
        public IList<CitationModel> Citations { get; set; }

        /// <summary>
        ///   Gets or sets the Facts of the Ancestor (Individual/Family).
        /// </summary>
        [JsonProperty("facts")]
        public IList<FactModel> Facts { get; set; }
    }
}