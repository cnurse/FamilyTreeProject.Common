using System;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// Citation is a class that represents a source citation
    /// </summary>
    public class Citation : OwnedEntity
    {
        public Citation() : this(String.Empty) { }

        public Citation(string treeId) : base(treeId, EntityType.Citation) { }

        /// <summary>
        /// The Date of the Citation
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The page number of the citation within the Source
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// The Id of the Source to which the citation is a part
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// The Source to which the citation belongs
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The text of the citation
        /// </summary>
        public string Text { get; set; }
    }
}
