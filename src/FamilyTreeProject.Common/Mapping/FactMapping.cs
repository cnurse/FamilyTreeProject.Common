using System;
using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class FactMapping
    {
        public static Fact ToModel(this FactModel fact)
        {
            Enum.TryParse(fact.Type, out FactType type);
            
            return new Fact
            {
                Date = fact.Date,
                Place = fact.Place,
                FactType = type,
                Citations = fact.Citations.ToModel(),
                Notes = fact.Notes.ToModel()
            };
            
        }

        public static IList<Fact> ToModel(this IList<FactModel> facts)
        {
            return facts.Select(fact => fact.ToModel()).ToList();
        }

        public static FactModel ToDataModel(this Fact fact)
        {
            return new FactModel
            {
                Date = fact.Date,
                Place = fact.Place,
                Type = fact.FactType.ToString(),
                Citations = fact.Citations.ToDataModel(),
                Notes = fact.Notes.ToDataModel()
            };
        }
        
        public static IList<FactModel> ToDataModel(this IList<Fact> facts)
        {
            return facts.Select(fact => fact.ToDataModel()).ToList();
        }                 
    }
}