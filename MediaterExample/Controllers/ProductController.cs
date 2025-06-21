using MediaterExample.Med.Commands;
using MediaterExample.Med.Queries;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace MediaterExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQuery
            {
                Id = id
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet()]

        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
