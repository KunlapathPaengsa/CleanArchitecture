using Microsoft.AspNetCore.Mvc;
using SaleProject.Application.Contracts.Executes;
using SaleProject.Application.Contracts.Middles;
using SaleProject.Application.Contracts.TakeAParts.Queries;

namespace SaleProject.WebAPI.Controllers
{
    //[ApiController, Route("[controller]")]
    public class TestExeController : APIControllerBase
    {
        [HttpGet("checking")]
        public async Task<string> Check() => await Mediator.Send(new TakeAPartQueryRequest());

        [HttpGet("excute")]
        public async Task<SeibelResultModel> Excute() => await Mediator.Send(new ExcuteQueryRequest());
        [HttpGet("middle")]
        public async Task<MiddleQueryResponse> Middle() => await Mediator.Send(new MiddleQueryRequest());
    }

}
