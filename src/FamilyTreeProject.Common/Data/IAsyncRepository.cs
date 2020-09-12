using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Naif.Core.Collections;

namespace FamilyTreeProject.Common.Data
{
    public interface IAsyncRepository<TModel> where TModel : class
    {
        /// <summary>
        /// Add an Item into the repository
        /// </summary>
        /// <param name="item">The item to be added</param>
        Task AddAsync(TModel item);

        /// <summary>
        /// Add a Collection of Items into the repository
        /// </summary>
        /// <param name="entities">The items to be added</param>
        Task AddAsync(IEnumerable<TModel> items);

        /// <summary>
        /// Determines whether an item exists in the repository
        /// </summary>
        /// <param name="id">The id of the item</param>
        /// <returns>True if the item exists, false if it does not.</returns>
        Task<bool> AnyAsync(string id);

        /// <summary>
        /// Delete an Item from the repository
        /// </summary>
        /// <param name="id">The id of the item to be deleted</param>
        Task DeleteAsync(string id);
        
        /// <summary>
        /// Find items from the repository based on a Linq predicate
        /// </summary>
        /// <param name="predicate">The Linq predicate"</param>
        /// <returns>A list of items</returns>
        Task<IEnumerable<TModel>> FindAsync(Func<TModel, bool> predicate);

        /// <summary>
        /// Find a Page of items from the repository based on a Linq predicate
        /// </summary>
        /// <param name="pageIndex">The page Index to fetch</param>
        /// <param name="pageSize">The size of the page to fetch</param>
        /// <param name="predicate">The Linq predicate"</param>
        /// <returns>A list of items</returns>
        Task<IPagedList<TModel>> FindAsync(int pageIndex, int pageSize, Func<TModel, bool> predicate);

        /// <summary>
        /// returns a single item from the repository
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The item</returns>
        Task<TModel> GetAsync(string id);

        /// <summary>
        /// Gets a list of items from the repository
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<IEnumerable<TModel>> GetAsync(IEnumerable<string> ids);

        /// <summary>
        /// Returns all the items in the repository as an enumerable list
        /// </summary>
        /// <returns>The list of items</returns>
        Task<IEnumerable<TModel>> GetAllAsync();

        /// <summary>
        /// Updates a single item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync(TModel item);
    }
}