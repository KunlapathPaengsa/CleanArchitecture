using MediatR;

namespace SaleProject.Application.Contracts.Greetings.Queries
{
    public class GreetingQueryRequest : IRequest<GreetingQueryResponse>
    {
        public string Name { get; set; } = "";
    }
}
