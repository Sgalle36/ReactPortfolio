using Microsoft.EntityFrameworkCore;
using MyPortfolio.Server.Interfaces;
using MyPortfolio.Server.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Server.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public virtual T Get(Expression<Func<T, bool>> predicate, bool trackChanges = false, string? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (predicate != null) query.Where(predicate);

            if (includes != null)
            {
                // includes = "comma,separated,objects,without,spaces"
                string[] includeProperties = StringHelpers.SplitCommaSeparatedString(includes);
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }

            if (!trackChanges) query.AsNoTracking();

            return query.FirstOrDefault();
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, Expression<Func<T, int>>? orderBy = null, string? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate != null) query.Where(predicate);

            if (includes != null)
            {
                string[] includeProperties = StringHelpers.SplitCommaSeparatedString(includes);
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }
            if (orderBy != null) return query.OrderBy(orderBy).ToList();

            return query.AsEnumerable();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Expression<Func<T, int>>? orderBy = null, string? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate != null) query.Where(predicate);

            if (includes != null)
            {
                string[] includeProperties = StringHelpers.SplitCommaSeparatedString(includes);
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }

            if (orderBy != null) return await query.OrderBy(orderBy).ToListAsync();

            return query.AsEnumerable();
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool trackChanges = false, string? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (predicate != null) query.Where(predicate);
            if (!trackChanges) query.AsNoTracking();

            if (includes != null)
            {
                string[] includeProperties = StringHelpers.SplitCommaSeparatedString(includes);
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }

            return await query.FirstOrDefaultAsync();
        }

        public virtual T GetById(int? id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            // for track changes I'm flagging modified to the system
            // this helps avoids concurrency issues
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Upsert(T entity, bool isNew)
        {
            if (isNew)
            {
                _context.Set<T>().Add(entity);
                return;
            }

            _context.Set<T>().Update(entity);
        }
    }
}