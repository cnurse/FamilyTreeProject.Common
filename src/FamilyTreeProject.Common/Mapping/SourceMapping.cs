using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class SourceMapping
    {
        public static Source ToModel(this SourceModel source)
        {
            return new Source
            {
                Author = source.Author,
                Publisher = source.Publisher,
                Title = source.Title,
                UniqueId = source.UniqueId,
                TreeId = source.TreeId,
                Notes = source.Notes.ToModel()
            };
        }

        public static IList<Source> ToModel(this IList<SourceModel> sources)
        {
            return sources.Select(source => source.ToModel()).ToList();
        }

        public static SourceModel ToDataModel(this Source source, bool includeEntityType)
        {
            return new SourceModel
            {
                Id = source.Id,
                Author = source.Author,
                EntityType =  includeEntityType ? source.EntityType.ToString() : null,
                Notes = source.Notes.ToDataModel(),
                Publisher = source.Publisher,
                Repository = source.RepositoryId,
                Title = source.Title,
                TreeId = source.TreeId,
                UniqueId = source.UniqueId
            };
        }
    }
}