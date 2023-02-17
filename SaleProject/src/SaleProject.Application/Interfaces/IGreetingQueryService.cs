using SaleProject.Application.Contracts.Greetings.Queries;

namespace SaleProject.Application.Interfaces
{
    public interface IGreetingQueryService
    {
        Task<GreetingQueryResponse> ResponseHello(GreetingQueryRequest request);
    }
}
