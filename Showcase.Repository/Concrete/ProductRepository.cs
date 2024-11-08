using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Repository.Context;

namespace Showcase.Repository.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ShowcaseDbContext _context;
        public ProductRepository(ShowcaseDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
