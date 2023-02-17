using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace SaleProject.WebAPI.Controllers
{
    [ApiController, Route("[controller]")]
    public class APIControllerBase : ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
