using Showcase.Core.Entities;
using Showcase.Repository.Abstract;
using Showcase.Service.Abstract;

namespace Showcase.Service.Concrete
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository genericRepo) : base(genericRepo)
        {
            _repository = genericRepo;
        }
    }
}
