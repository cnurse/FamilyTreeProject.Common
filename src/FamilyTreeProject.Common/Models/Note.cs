// ReSharper disable ConvertPropertyToExpressionBody

using System;

namespace FamilyTreeProject.Common.Models
{
    /// <summary>
    /// Note is a class that represents a Note
    /// </summary>
    public class Note : OwnedEntity
    {
        public Note() : this(String.Empty) { }

        public Note(string treeId) : base(treeId, EntityType.Note) { }

        /// <summary>
        /// The text of the Note
        /// </summary>
        public string Text { get; set; }
    }
}