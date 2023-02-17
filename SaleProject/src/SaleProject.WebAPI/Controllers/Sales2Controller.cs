using MediatR;
using Microsoft.AspNetCore.Mvc;
using SaleProject.Application.Contracts.TakeAParts.Arrays;
using SaleProject.Application.Contracts.TakeAParts.Queries;

namespace SaleProject.WebAPI.Controllers
{
    //[ApiController, Route("[controller]")]
    public class Sales2Controller : APIControllerBase
    {
        [HttpGet("checking")]
        public async Task<string> Check() => await Mediator.Send(new TakeAPartQueryRequest());

        [HttpGet("array")]
        public async Task<string[]> GetCarEnum([FromQuery] TakeArrayPartQueryRequest request) => await Mediator.Send(request);
    }

}
