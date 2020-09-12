using System;
using System.Collections.Generic;
using Naif.Core.Collections;

namespace FamilyTreeProject.Common.Data
{
    public interface IRepository
    {
        
    }
    
    public interface IRepository<T> : IRepository where T : class
    {
        /// <summary>
        /// A flag that indicates whether the repository supports domain aggregates
        /// </summary>
        bool SupportsAggregates { get; }
        
        /// <summary>
        /// Add an Item into the repository
        /// </summary>
        /// <param name="item">The item to be added</param>
        void Add(T item);

        /// <summary>
        /// Delete an Item from the repository
        /// </summary>
        /// <param name="item">The item to be deleted</param>
        void Delete(T item);

        /// <summary>
        /// Find items from the repository based on a Linq predicate
        /// </summary>
        /// <param name="predicate">The Linq predicate"</param>
        /// <returns>A list of items</returns>
        IEnumerable<T> Find(Func<T, bool> predicate);

        /// <summary>
        /// Find a Page of items from the repository based on a Linq predicate
        /// </summary>
        /// <param name="pageIndex">The page Index to fetch</param>
        /// <param name="pageSize">The size of the page to fetch</param>
        /// <param name="predicate">The Linq predicate"</param>
        /// <returns>A list of items</returns>
        IPagedList<T> Find(int pageIndex, int pageSize, Func<T, bool> predicate);

        /// <summary>
        /// Returns all the items in the repository as an enumerable list
        /// </summary>
        /// <returns>The list of items</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Returns a page of items in the repository as a paged list
        /// </summary>
        /// <param name="pageIndex">The page Index to fetch</param>
        /// <param name="pageSize">The size of the page to fetch</param>
        /// <returns>The list of items</returns>
        IPagedList<T> GetPage(int pageIndex, int pageSize);

        /// <summary>
        /// Updates an Item in the repository
        /// </summary>
        /// <param name="item">The item to be updated</param>
        void Update(T item);
    }
}