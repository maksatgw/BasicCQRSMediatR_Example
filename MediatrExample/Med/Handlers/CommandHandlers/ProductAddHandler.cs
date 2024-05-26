using MediatR;
using MediatrExample.Entities;
using MediatrExample.Med.Commands.Request;
using MediatrExample.Med.Commands.Response;
using MediatrExample.Service;
using System.Diagnostics;

namespace MediatrExample.Med.Handlers.CommandHandlers
{
    //IRequestHandler Interface'inden türer. Bir tane request ve bir tane response handle eder. 
    public class ProductAddHandler : IRequestHandler<ProductAddCommand, ProductAddViewModel>
    {
        private readonly IProductService _service;

        public ProductAddHandler(IProductService service)
        {
            _service = service;
        }

        //Interface'den gelen implement edilmiş handle metodu.
        //Bu metot tetiklendiğinde ilgili Query tetiklenmiş demektir.
        public Task<ProductAddViewModel> Handle(ProductAddCommand request, CancellationToken cancellationToken)
        {
            var data = new ProductEntity()
            {
                Id = Guid.NewGuid(),
                Amount = request.Amount,
                Name = request.Name,
                Quantity = request.Quantity,
            };

            _service.Add(data);

            var viewModel = new ProductAddViewModel()
            {
                Id = data.Id,
                Amount= request.Amount,
                Name= request.Name,
                Quantity = request.Quantity,
                IsSuccess = true
            };

            return Task.FromResult(viewModel);
        }
    }
}
