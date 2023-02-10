using System;
using FamilyTreeProject.Common.Data;
using FamilyTreeProject.Common.Models;
using Naif.Core.Contracts;

namespace FamilyTreeProject.Common.IO
{
    public abstract class FileUnitOfWork : IUnitOfWork
    {
        protected FileUnitOfWork()
        {
        }

        protected FileUnitOfWork(IFileStore store)
        {
            Requires.NotNull("store", store);

            Initialize(store);
        }
        
        public IFileStore Store { get; set; }

        protected void Initialize(IFileStore store)
        {
            Store = store;
        }
        
        public void BeginTransaction()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Commit()
        {
            Store.SaveChanges();
        }

        
        public IRepository<T> GetRepository<T>() where T : Entity
        {
            if (typeof(T) == typeof(Tree))
            {
                return new TreeRepository(Store) as IRepository<T>;
            }
            if (typeof(T) == typeof(Individual))
            {
                return new IndividualRepository(Store) as IRepository<T>;
            }
            if (typeof(T) == typeof(Family))
            {
                return new FamilyRepository(Store) as IRepository<T>;
            }
            if (typeof(T) == typeof(Repository))
            {
                return new RepositoryRepository(Store) as IRepository<T>;
            }
            if (typeof(T) == typeof(Source))
            {
                return new SourceRepository(Store) as IRepository<T>;
            }
            throw new NotImplementedException();
        }
        
        public void RollbackTransaction()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

    }
}