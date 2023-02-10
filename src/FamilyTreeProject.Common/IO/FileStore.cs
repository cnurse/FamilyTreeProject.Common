using System.Collections.Generic;
using System.IO;
using FamilyTreeProject.Common.Data;
using FamilyTreeProject.Common.Models;
using Naif.Core.Contracts;

namespace FamilyTreeProject.Common.IO
{
    public abstract class FileStore : IFileStore
    {
        private readonly string _path;
        protected readonly IDocument Document;

        public Tree Tree { get; set; }
        public IList<Family> Families { get; protected set; }
        public IList<Individual> Individuals { get; protected set; }
        public IList<Repository> Repositories { get; protected set; }
        public IList<Source> Sources { get; protected set; }

        protected FileStore(string path, IDocument document)
        {
            Requires.NotNullOrEmpty("path", path);

            _path = path;
            Document = document;
            
            Initialize();
        }

        private void Initialize()
        {
            LoadDocument();

            Tree = new Tree();
            
            Families = new List<Family>();
            Individuals = new List<Individual>();
            Repositories = new List<Repository>();
            Sources = new List<Source>();

            LoadTree();
            LoadIndividuals();
            LoadFamilies();
            LoadRepositories();
            LoadSources();
        }

        private void LoadDocument()
        {
            using (var stream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                Document.Load(stream);
            }
        }

        protected abstract void LoadFamilies();

        protected abstract void LoadIndividuals();

        protected abstract void LoadRepositories();

        protected abstract void LoadSources();

        protected abstract void LoadTree();

        public virtual void AddFamily(Family family)
        {
            Families.Add(family);
        }

        public virtual void AddIndividual(Individual individual)
        {
            Individuals.Add(individual);
        }

        public virtual void AddRepository(Repository repository)
        {
            Repositories.Add(repository);
        }

        public virtual void AddSource(Source source)
        {
            Sources.Add(source);
        }

        public virtual void AddTree(Tree tree)
        {
            Tree = tree;
        }

        public abstract void DeleteFamily(Family family);

        public abstract void DeleteIndividual(Individual individual);

        public abstract void DeleteRepository(Repository repository);

        public abstract void DeleteSource(Source source);

        public abstract void DeleteTree(Tree tree);

        public virtual void SaveChanges()
        {
            using (var stream = new FileStream(_path, FileMode.Create, FileAccess.Write))
            {
                Document.Save(stream);
            }
        }

        public abstract void UpdateFamily(Family family);

        public virtual void UpdateIndividual(Individual individual)
        {
            //Do nothing
        }

        public abstract void UpdateRepository(Repository repository);

        public abstract void UpdateSource(Source source);

        public abstract void UpdateTree(Tree tree);
    }
}