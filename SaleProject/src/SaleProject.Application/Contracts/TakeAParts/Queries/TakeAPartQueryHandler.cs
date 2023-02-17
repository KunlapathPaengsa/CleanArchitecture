using MediatR;

namespace SaleProject.Application.Contracts.TakeAParts.Queries
{
    public class TakeAPartQueryHandler : IRequestHandler<TakeAPartQueryRequest, string>
    {
        public Task<string> Handle(TakeAPartQueryRequest request, CancellationToken cancellationToken) => Task.FromResult("200OK");
    }
}
