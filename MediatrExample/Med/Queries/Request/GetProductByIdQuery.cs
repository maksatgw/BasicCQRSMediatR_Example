using MediatR;
using MediatrExample.Med.Queries.Response;

namespace MediatrExample.Med.Queries.Request
{
    //IRequest isminde bir Inteface mevcut. Bu query çağrıldığı zaman geriye response olarak ne dönmek istiyorsak bizden onu bekler.

    public class GetProductByIdQuery : IRequest<ProductGetProductByIdViewModel>
    {
        public Guid ProductId { get; set; }
    }
}
