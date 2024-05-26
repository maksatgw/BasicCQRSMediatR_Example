using MediatR;
using MediatrExample.Entities;
using MediatrExample.Med.Commands.Request;
using MediatrExample.Med.Queries;
using MediatrExample.Med.Queries.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //MediatR kütüphanemizi DI ile kullanıyoruz.
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            //Yapmamız gereken mediator içine bir query göndermek.
            var query = new GetProductByIdQuery()
            {
                ProductId = id  
            };
            //MediatR içindeki send metodu, ilgili handler metodunu bulacak ve tetikleyecek.
            //Bir viewModel dönecek.
            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            var query = new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(ProductAddCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
