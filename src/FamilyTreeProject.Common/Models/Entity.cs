using System.Collections.Generic;

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// Entities are the main objects in the Family Tree (represented by Records in GEDCOM),
    /// Individuals, Families, Sources and Repositories are entities.
    /// While not represented by records in GEDCOM Facts are also Entities (as they have Notes)
    /// </summary>
    public class Entity : BaseEntity, IUniqueEntity
    {
        /// <summary>
        /// Constructs an Entity.
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        /// <param name="entityType"></param>
        protected Entity(string treeId, EntityType entityType): base(entityType)
        {
            Multimedia = new List<MultimediaLink>();
            Notes = new List<Note>();
            TreeId = treeId;
        }

        /// <summary>
        /// A list of Multimedia Links
        /// </summary>
        public IList<MultimediaLink> Multimedia { get; set; }

        /// <summary>
        /// A list of Notes
        /// </summary>
        public IList<Note> Notes { get; set; }
        
        /// <summary>
        /// The Id of the Tree to which this entity belongs
        /// </summary>
        public string TreeId { get; set; }
        
        /// <summary>
        /// A Globally Unique Identifier for the Entity
        /// </summary>
        public string UniqueId { get; set; }
    }
}
