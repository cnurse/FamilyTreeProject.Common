using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common.DataModels;
using FamilyTreeProject.Common.Models;

namespace FamilyTreeProject.Common.Mapping
{
    public static class NoteMapping
    {
        public static Note ToModel(this NoteModel note)
        {
            return new Note
            {
                Text = note.Text
            };
        }

        public static IList<Note> ToModel(this IList<NoteModel> notes)
        {
            return notes.Select(note => note.ToModel()).ToList();
        }

        public static NoteModel ToDataModel(this Note note)
        {
            return new NoteModel
            {
                Text = note.Text
            };
        }
        
        public static IList<NoteModel> ToDataModel(this IList<Note> notes)
        {
            return notes.Select(note => note.ToDataModel()).ToList();
        }                 
    }
}