using OrderingSample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSample.Core.Business
{
    public interface IService<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey key);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
    }

    public interface IService<TEntity> : IService<TEntity, int> where TEntity : class, IEntity, new() { }
}
