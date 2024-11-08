using Microsoft.EntityFrameworkCore;
using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Repository.Context;
using System.Linq.Expressions;

namespace Showcase.Repository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ShowcaseDbContext _context;
        private readonly DbSet<T> _entities;
        public GenericRepository(ShowcaseDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null)
        {
            return _entities.Where(predicate);
        }

        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _entities.CountAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }



        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
