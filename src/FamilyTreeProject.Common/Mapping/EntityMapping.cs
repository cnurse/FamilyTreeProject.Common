using System;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class EntityMapping
    {
        public static Entity ToModel(this BaseModel model)
        {
            if (model is TreeModel tree)
            {
                return TreeMapping.ToModel(tree);
            }

            throw new NotImplementedException();
        }

        public static BaseModel ToDataModel(this Entity entity, bool includeEntityType)
        {
            if (entity is Tree tree)
            {
                return tree.ToDataModel(includeEntityType);
            }
            if (entity is Repository repository)
            {
                return repository.ToDataModel(includeEntityType);
            }
            if (entity is Source source)
            {
                return source.ToDataModel(includeEntityType);
            }
            if (entity is Individual individual)
            {
                return individual.ToDataModel(includeEntityType);
            }
            if (entity is Family family)
            {
                return family.ToDataModel(includeEntityType);
            }

            throw new NotImplementedException();
        }
    }
}