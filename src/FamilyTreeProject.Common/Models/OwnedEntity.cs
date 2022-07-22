namespace FamilyTreeProject.Common.Models
{
    public abstract class OwnedEntity : Entity
    {
        /// <summary>
        /// Constructs an OwnedEntity.
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        /// <param name="entityType"></param>
        protected OwnedEntity(string treeId, EntityType entityType) : base(treeId, entityType) { }

        /// <summary>
        /// The Id of the owner entity
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// The type of the owner entity
        /// </summary>
        public EntityType OwnerType { get; set; }
    }
}
