using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tshopper.DataAcessLayer
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task Delete(object id);
        Task<TEntity> GetByID(object id);
        Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
              Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
              string includeProperties = "");
    }
}
