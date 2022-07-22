using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class FamilyMapping
    {
        public static Family ToModel(this FamilyModel family)
        {
            return new Family
            {
                Facts = family.Facts.ToModel(),
                Notes = family.Notes.ToModel(),
                TreeId = family.TreeId,
                UniqueId = family.UniqueId
            };
        }

        public static IList<Family> ToModel(this IList<FamilyModel> families)
        {
            return families.Select(family => family.ToModel()).ToList();
        }

        public static FamilyModel ToDataModel(this Family family, bool includeEntityType)
        {
            return new FamilyModel
            {
                Id = family.Id,
                Citations = family.Citations.ToDataModel(),
                EntityType =  includeEntityType ? family.EntityType.ToString() : null,
                Facts = family.Facts.ToDataModel(),
                Husband = family.HusbandId,
                Notes = family.Notes.ToDataModel(),
                TreeId = family.TreeId,
                UniqueId = family.UniqueId,
                Wife = family.WifeId,
            };
        }
    }
}