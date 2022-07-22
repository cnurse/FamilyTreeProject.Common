using Newtonsoft.Json;

namespace FamilyTreeProject.Common.DataModels
{
    public class NoteModel
    {
        /// <summary>
        /// The text of the Note
        /// </summary>
        [JsonProperty("note")]
        public string Text { get; set; }
    }
}