using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SaleProject.Application.Contracts.TakeAParts.Arrays
{
    public class TakeArrayPartQueryRequest : IRequest<string[]>
    {
        public bool IsValue { get; set; }
    }
}