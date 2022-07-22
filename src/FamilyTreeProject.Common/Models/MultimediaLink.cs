using System;

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// MultimediaLink is a class that represents a Link to multimedia content
    /// </summary>
    public class MultimediaLink : OwnedEntity
    {
        public MultimediaLink() : this(String.Empty) { }

        public MultimediaLink(string treeId) : base(treeId, EntityType.Multimedia) { }

		/// <summary>
        /// The file path (or Uri)
        /// </summary>
		public string File { get; set; }

		/// <summary>
        /// The type of the multimedia (jpg, mp3 etc)
        /// </summary>
		public string Format { get; set; }

		/// <summary>
        /// The title of the Multimedia
        /// </summary>
		public string Title { get; set; }
    }
}
