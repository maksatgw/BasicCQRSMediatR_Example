using MediatR;
using MediatrExample.Med.Commands.Response;

namespace MediatrExample.Med.Commands.Request
{
    //IRequest isminde bir Inteface mevcut. Bu query çağrıldığı zaman geriye response olarak ne dönmek istiyorsak bizden onu bekler.
    public class ProductAddCommand : IRequest<ProductAddViewModel>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
