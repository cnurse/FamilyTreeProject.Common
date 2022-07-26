﻿using System.Collections.Generic;

namespace FamilyTreeProject.Common.Models
{
    public abstract class AncestorEntity : Entity
    {
        protected AncestorEntity(string treeId, EntityType entityType) : base(treeId, entityType)
        {
            Children = new List<Individual>();
            Facts = new List<Fact>();
            Citations = new List<Citation>();
        }

        /// <summary>
        ///   Gets or sets the Children of the Ancestor (Individual/Family).
        /// </summary>
        public IList<Individual> Children { get; set; }

        /// <summary>
        ///   Gets or sets the Citations for the Ancestor (Individual/Family)
        /// </summary>
        public IList<Citation> Citations { get; set; }

        /// <summary>
        ///   Gets or sets the Facts of the Ancestor (Individual/Family).
        /// </summary>
        public IList<Fact> Facts { get; set; }
    }
}
