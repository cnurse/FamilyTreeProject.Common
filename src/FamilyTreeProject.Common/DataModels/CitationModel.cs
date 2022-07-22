using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class CitationModel : BaseModel
    {
        /// <summary>
        /// The Date of the Citation
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// The page number of the citation within the Source
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// The Source to which the citation is a part
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The text of the citation
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}