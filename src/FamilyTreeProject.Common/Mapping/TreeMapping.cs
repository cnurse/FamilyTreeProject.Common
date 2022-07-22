using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class TreeMapping
    {
        public static Tree ToModel(this TreeModel tree)
        {
            return new Tree
            {
                Description = tree.Description,
                Name = tree.Name,
                OwnerId = tree.Owner,
                Title =tree.Title,
                UniqueId = tree.UniqueId,
                Notes = tree.Notes.ToModel()
            };
            
        }

        public static TreeModel ToDataModel(this Tree tree, bool includeEntityType)
        {
            return new TreeModel
            {
                Description = tree.Description,
                Name = tree.Name,
                Owner = tree.OwnerId,
                Title = tree.Title,
                UniqueId = tree.UniqueId,
                EntityType =  includeEntityType ? tree.EntityType.ToString() : null,
                Notes = tree.Notes.ToDataModel()
            };
        }
    }
}