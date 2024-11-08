using Showcase.Core.Entities;
using System.Linq.Expressions;

namespace Showcase.Repository.Abstract
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        IQueryable<T> GetQueryable(Expression<Func<T,bool>> predicate = null);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        void Update(T entity);
        Task<int> CountAsync();



    }
}
