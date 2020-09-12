using System.IO;

namespace FamilyTreeProject.Common.Data
{
    public interface IDocument
    {
        void Load(Stream stream);
        
        void Save(Stream stream);
    }
}