using MediatrExample.Entities;

namespace MediatrExample.Service
{
    public interface IProductService
    {
        List<ProductEntity> GetAll();
        ProductEntity GetById(Guid id);
        void Add(ProductEntity productEntity);
    }
}
