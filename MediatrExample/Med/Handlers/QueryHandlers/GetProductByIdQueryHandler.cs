using MediatR;
using MediatrExample.Med.Queries.Request;
using MediatrExample.Med.Queries.Response;
using MediatrExample.Service;

namespace MediatrExample.Med.Handlers.QueryHandlers
{
    //IRequestHandler Interface'inden türer. Bir tane request ve bir tane response handle eder. 
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductGetProductByIdViewModel>
    {
        private readonly IProductService _service;

        public GetProductByIdQueryHandler(IProductService service)
        {
            _service = service;
        }

        //Interface'den gelen implement edilmiş handle metodu.
        //Bu metot tetiklendiğinde ilgili Query tetiklenmiş demektir.
        public Task<ProductGetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var product = _service.GetById(request.ProductId);
            var viewModel = new ProductGetProductByIdViewModel()
            {
                Id = product.Id,
                Name = product.Name
            };
            
            return Task.FromResult(viewModel);

            //Get Product from repository
        }
    }
}
