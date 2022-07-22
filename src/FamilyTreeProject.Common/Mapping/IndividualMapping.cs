using System;
using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class IndividualMapping
    {
        public static Individual ToModel(this IndividualModel individual)
        {
            Enum.TryParse(individual.Sex, out Sex sex);

            return new Individual
            {
                Facts = individual.Facts.ToModel(),
                FirstName = individual.FirstName,
                LastName = individual.LastName,
                Notes = individual.Notes.ToModel(),
                Sex = sex,
                TreeId = individual.TreeId,
                UniqueId = individual.UniqueId
            };
        }

        public static IList<Individual> ToModel(this IList<IndividualModel> individuals)
        {
            return individuals.Select(individual => individual.ToModel()).ToList();
        }

        public static IndividualModel ToDataModel(this Individual individual, bool includeEntityType)
        {
            return new IndividualModel
            {
                Id = individual.Id,
                Citations = individual.Citations.ToDataModel(),
                EntityType =  includeEntityType ? individual.EntityType.ToString() : null,               
                Facts = individual.Facts.ToDataModel(),
                Father = individual.FatherId,
                FirstName = individual.FirstName,
                LastName = individual.LastName,
                Mother = individual.MotherId,
                Notes = individual.Notes.ToDataModel(),
                Sex = individual.Sex.ToString(),
                TreeId = individual.TreeId,
                UniqueId = individual.UniqueId
            };
        }
         
    }
}