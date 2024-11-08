using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Repository.Context;

namespace Showcase.Repository.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ShowcaseDbContext _context;
        public CategoryRepository(ShowcaseDbContext context) : base(context)
        {
            _context = context; 
        }
    }
}
