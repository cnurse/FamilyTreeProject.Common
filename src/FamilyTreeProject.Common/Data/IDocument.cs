using System.IO;

namespace FamilyTreeProject.Core.Data
{
    public interface IDocument
    {
        void Load(Stream stream);
        
        void Save(Stream stream);
    }
}