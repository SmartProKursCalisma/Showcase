using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Service.Abstract;

namespace Showcase.Service.Concrete
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepo) : base(categoryRepo)
        {
            _categoryRepository = categoryRepo;
        }
    }
}
