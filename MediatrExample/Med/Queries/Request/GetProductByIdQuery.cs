using MediatR;
using MediatrExample.Med.Queries.Response;

namespace MediatrExample.Med.Queries.Request
{
    public class GetProductByIdQuery : IRequest<ProductGetProductByIdViewModel>
    {
        public Guid ProductId { get; set; }
    }
}
