using MediatR;
using MediatrExample.Med.Queries.Request;
using MediatrExample.Med.Queries.Response;
using MediatrExample.Service;

namespace MediatrExample.Med.Handlers.QueryHandlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductGetProductByIdViewModel>
    {
        private readonly IProductService _service;

        public GetProductByIdQueryHandler(IProductService service)
        {
            _service = service;
        }

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
