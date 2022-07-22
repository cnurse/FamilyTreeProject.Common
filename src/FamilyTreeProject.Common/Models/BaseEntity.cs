// ReSharper disable ConvertPropertyToExpressionBody

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// The BaseEntity class provides a base class for Family Tree Entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Constructs a Base Entity
        /// </summary>
        protected BaseEntity(EntityType entityType)
        {
            Id = 0;
            EntityType = entityType;
        }

        /// <summary>
        /// Gets the type of Entity
        /// </summary>
        public EntityType EntityType {get; protected set; }

        /// <summary>
        ///   Gets or sets the id of the entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This property indicates whether the entity is New
        /// </summary>
        public bool IsNew
        {
            get { return Id > 0; }
        }
    }
}
