using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class RepositoryMapping
    {
        public static Repository ToModel(this RepositoryModel repository)
        {
            return new Repository
            {
                Address = repository.Address,
                Name = repository.Name,
                TreeId = repository.TreeId,
                UniqueId = repository.UniqueId,
                Notes = repository.Notes.ToModel()
            };
        }

        public static IList<Repository> ToModel(this IList<RepositoryModel> repositories)
        {
            return repositories.Select(repository => repository.ToModel()).ToList();
        }

        public static RepositoryModel ToDataModel(this Repository repository, bool includeEntityType)
        {
            return new RepositoryModel
            {
                Id = repository.Id,
                Address = repository.Address,
                EntityType =  includeEntityType ? repository.EntityType.ToString() : null,
                Name = repository.Name,
                TreeId = repository.TreeId,
                UniqueId = repository.UniqueId,
                Notes = repository.Notes.ToDataModel()
            };
        }
    }
}