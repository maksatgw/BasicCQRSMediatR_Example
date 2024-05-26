using MediatR;
using MediatrExample.Med.Commands.Response;

namespace MediatrExample.Med.Commands.Request
{
    public class ProductAddCommand : IRequest<ProductAddViewModel>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
