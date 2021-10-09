using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tshopper.Infrastructure;

namespace Tshopper.DataAcessLayer
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal TshopperContext _context { get; set; }
        internal DbSet<TEntity> _dbSet { get; set; }

        public GenericRepository(TshopperContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async virtual Task Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _context.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public async virtual Task Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);
            await Delete(entity);
        }


        public async virtual Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query.AsQueryable();
            }
        }

        public async virtual Task<TEntity> GetByID(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async virtual Task Insert(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async virtual Task Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
