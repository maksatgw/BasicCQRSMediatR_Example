using MediatrExample.Entities;

namespace MediatrExample.Service
{
    public class ProductService : IProductService
    {
        private readonly List<ProductEntity> _products;

        public ProductService()
        {
            _products = new List<ProductEntity>();
        }

        public void Add(ProductEntity productEntity)
        {
            _products.Add(productEntity);
        }

        public List<ProductEntity> GetAll()
        {
            return _products;
        }

        public ProductEntity GetById(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }
    }
}
