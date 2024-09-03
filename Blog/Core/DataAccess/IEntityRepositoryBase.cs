using Amazon.SecurityToken.Model;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(string id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(string id, TEntity entity);
        Task DeleteAsync(string id);
        TEntity Get(Expression<Func<TEntity,bool>> filter);
    }
}
