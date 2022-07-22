using System;

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// Represents a Family Tree
    /// </summary>
    public class Tree : Entity
    {
        public Tree() : base(null, EntityType.Tree)
        {
            Name = String.Empty;
            Title = String.Empty;
            Description = String.Empty;
            HomeIndividualId = -1;
            ImageId = -1;
            LastViewedIndividualId = -1;
            OwnerId = String.Empty;
        }

        /// <summary>
        /// The Description of the Tree
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Id of the current home or root individual
        /// </summary>
        public int HomeIndividualId { get; set; }

        /// <summary>
        /// The Id of the image displayed on the main view
        /// </summary>
        public int ImageId { get; set; }

        /// <summary>
        /// The Id of the last viewed individual
        /// </summary>
        public int LastViewedIndividualId { get; set; }

        /// <summary>
        /// The Name of the Tree
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The owner of the tree (this Id can be used to associate trees with "users")
        /// An implementation system will manage the "owning" of a tree
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// The Title of the Tree
        /// </summary>
        public string Title { get; set; }
    }
}
