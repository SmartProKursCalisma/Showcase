using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Service.Abstract;
using System.Linq.Expressions;

namespace Showcase.Service.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _genericRepo;

        public GenericService(IGenericRepository<T> genericRepo)
        {
            _genericRepo = genericRepo;
        }

        public async Task AddAsync(T entity)
        {
           await _genericRepo.AddAsync(entity);
        }

        public async Task<int> CountAsync()
        {
           return await _genericRepo.CountAsync();
        }

        public async Task DeleteAsync(int id)
        {
           await _genericRepo.DeleteAsync(id);    
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _genericRepo.GetAllAsync();
        }

        public Task<T> GetAsync(int id)
        {
            return _genericRepo.GetAsync(id);
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
        {
            return _genericRepo.GetQueryable(predicate);
        }

        public void Update(T entity)
        {
            _genericRepo.Update(entity);
        }
    }
}
