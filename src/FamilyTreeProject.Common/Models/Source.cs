using System;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// Represents a Source in a Family Tree
    /// </summary>
    public class Source : Entity
    {
        public Source() : this(String.Empty) { }

        public Source(string treeId) : base(treeId, EntityType.Source)
        {
            Author = String.Empty;
            Publisher = String.Empty;
            Title = String.Empty;
            RepositoryId = null;
        }

        /// <summary>
        /// Gets and sets the Author of the Source
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets and sets the Publisher of the Source
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Gets and sets the Id of the Repository where the Source can be found
        /// </summary>
        public string RepositoryId { get; set; }

        /// <summary>
        /// Gets and sets the Repository where the Source can be found
        /// </summary>
        public Repository Repository { get; set; }

        /// <summary>
        /// Gets and sets the Title of the Source
        /// </summary>
        public string Title { get; set; }
    }
}
