using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class SourceModel : EntityModel
    {
        /// <summary>
        /// Gets and sets the Author of the Source
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets and sets the Publisher of the Source
        /// </summary>
        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets and sets the Repository where the Source can be found
        /// </summary>
        [JsonProperty("repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets and sets the Title of the Source
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}