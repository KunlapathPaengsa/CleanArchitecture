using Microsoft.AspNetCore.Mvc;
using SaleProject.Application.Contracts.Checkings.Queries;
using SaleProject.Application.Contracts.Greetings.Queries;
using SaleProject.Application.Contracts.Students;
using SaleProject.Infrastructure.Contexts;

namespace SaleProject.WebAPI.Controllers
{
    public class SalesController : APIControllerBase
    {
        [HttpGet("checking")]
        public async Task<CheckingQueryResponse> Check() => await Mediator.Send(new CheckingQueryRequest());

        [HttpGet("greeting")]
        public async Task<GreetingQueryResponse> Hello([FromQuery] GreetingQueryRequest request) => await Mediator.Send(request);

        [HttpGet("GetAllStudent")]
        public async Task<List<Student>> Get([FromQuery]GetAllStudentQueryRequest request) => await Mediator.Send(request);
    }
}
