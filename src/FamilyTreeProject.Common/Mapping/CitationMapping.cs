using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class CitationMapping
    {
        public static Citation ToModel(this CitationModel citation)
        {
            return new Citation
            {
                Date = citation.Date,
                Page = citation.Page,
                Text = citation.Text,
                Notes = citation.Notes.ToModel()
            };
        }

        public static IList<Citation> ToModel(this IList<CitationModel> citations)
        {
            return citations.Select(citation => citation.ToModel()).ToList();
        }

        public static CitationModel ToDataModel(this Citation citation)
        {
            return new CitationModel
            {
                Date = citation.Date,
                Page = citation.Page,
                Text = citation.Text,
                Notes = citation.Notes.ToDataModel(),
                Source = citation.SourceId
            };
        }
        
        public static IList<CitationModel> ToDataModel(this IList<Citation> citations)
        {
            return citations.Select(citation => citation.ToDataModel()).ToList();
        }                 
    }
}