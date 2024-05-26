using MediatR;
using MediatrExample.Med.Queries.Response;

namespace MediatrExample.Med.Queries.Request
{
    public class GetAllProductQuery : IRequest<List<ProductGetAllViewModel>>
    {
    }
}
