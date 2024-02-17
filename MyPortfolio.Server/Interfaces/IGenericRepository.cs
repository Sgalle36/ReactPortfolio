using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Server.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get an object by its key id
        /// </summary>
        /// <param name="id">Id of the object to get</param>
        /// <returns>A single object instance</returns>
        T GetById(int? id);

        /// <summary>
        /// Get set of objects using an expression
        //  filter (similar to where clause in SQL)
        /// </summary>
        /// <param name="predicate">Similar to SQL where clause used to filter objects</param>
        /// <param name="trackChanges">Used to enable tracking object changes, default null</param>
        /// <param name="includes">To join tables by including them with the filter</param>
        /// <returns>A set of objects</returns>
        T Get(Expression<Func<T, bool>> predicate, bool trackChanges = false, string? includes = null);

        /// <summary>
        /// Get set of objects using an expression filter (similar to where clause in SQL)
        /// </summary>
        /// <param name="predicate">Similar to SQL where clause used to filter objects</param>
        /// <param name="trackChanges">Used to enable tracking object changes, default null</param>
        /// <param name="includes">To join tables by including them with the filter</param>
        /// <returns>Asyncronous set of objects</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false, string? includes = null);

        /// <summary>
        /// Get list of objects and return objects as enumerable
        /// </summary>
        /// <param name="predicate">Similar to SQL where clause used to filter objects</param>
        /// <param name="orderBy"></param>
        /// <returns>Enumerable list of objects</returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, Expression<Func<T, int>>? orderBy = null, string? includes = null);

        /// <summary>
        /// Get list of objects and return objects as enumerable asyncronously
        /// </summary>
        /// <param name="predicate">Similar to SQL where clause used to filter objects</param>
        /// <param name="orderBy"></param>
        /// <returns>Async enumerable list of objects</returns>
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Expression<Func<T, int>>? orderBy = null, string? includes = null);

        /// <summary>
        /// Add a new instance of the object
        /// </summary>
        /// <param name="entity">The new entity to add</param>
        void Add(T entity);

        /// <summary>
        /// Remove a single instance of an object
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        void Delete(T entity);

        /// <summary>
        /// Remove (Delete) multiple objects
        /// </summary>
        /// <param name="entities">The entities to delete</param>
        void Delete(IEnumerable<T> entities);

        /// <summary>
        /// Update changes to an object
        /// </summary>
        /// <param name="entity">The entity to update</param>
        void Update(T entity);

        /// <summary>
        /// Creates a new entity or updates if it's an existing entity
        /// </summary>
        /// <param name="entity">Object to upsert</param>
        /// <param name="isNew">True or false, object is new</param>
        void Upsert(T entity, bool isNew);

    }
}
