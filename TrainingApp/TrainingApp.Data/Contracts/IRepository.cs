using System.Linq.Expressions;

namespace TrainingApp.Data.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
        Task DeleteByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<TEntity> GetByIDAsync(int id);
        Task InsertAsync(TEntity entity, bool deferCommit = false);
        Task UpdateAsync(TEntity entity);
    }
}