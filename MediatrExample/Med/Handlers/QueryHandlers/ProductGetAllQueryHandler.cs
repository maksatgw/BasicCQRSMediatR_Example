using MediatR;
using MediatrExample.Med.Queries.Request;
using MediatrExample.Med.Queries.Response;
using MediatrExample.Service;

namespace MediatrExample.Med.Handlers.QueryHandlers
{
    //IRequestHandler Interface'inden türer. Bir tane request ve bir tane response handle eder. 
    public class ProductGetAllQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductGetAllViewModel>>
    {
        private readonly IProductService _service;

        public ProductGetAllQueryHandler(IProductService service)
        {
            _service = service;
        }

        //Interface'den gelen implement edilmiş handle metodu.
        //Bu metot tetiklendiğinde ilgili Query tetiklenmiş demektir.
        public Task<List<ProductGetAllViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var product = _service.GetAll();
            var viewModel = product.Select(x => new ProductGetAllViewModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();

            return Task.FromResult(viewModel);
        }
    }
}
