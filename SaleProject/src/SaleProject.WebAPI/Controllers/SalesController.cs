using Microsoft.AspNetCore.Mvc;
using MediatR;
using SaleProject.Application.Contracts.Queries;

namespace SaleProject.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SalesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<CheckingQueryResponse> Get()
        {
            return await _mediator.Send(new CheckingQueryRequest());
        }
    }
}
