using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace SaleProject.WebAPI.Controllers
{
    public class APIControllerBase : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public APIControllerBase(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
