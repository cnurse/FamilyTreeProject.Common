using System;

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// The Repository class represents a repository of Family Tree information (this could be a website or a library for example)
    /// </summary>
    public class Repository : Entity
    {
        public Repository() : this(String.Empty) { }

        public Repository(string treeId) : base(treeId, EntityType.Repository) { }

        /// <summary>
        /// The Address of the Repository
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The Name of the Repository
        /// </summary>
        public string Name { get; set; }
    }
}
