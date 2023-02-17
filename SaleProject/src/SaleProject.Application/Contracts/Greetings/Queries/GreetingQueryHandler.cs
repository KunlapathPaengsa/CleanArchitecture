using MediatR;

namespace SaleProject.Application.Contracts.Greetings.Queries
{
    public class GreetingQueryHandler : IRequestHandler<GreetingQueryRequest, GreetingQueryResponse>
    {
        public async Task<GreetingQueryResponse> Handle(GreetingQueryRequest request, CancellationToken cancellationToken)
        {
            return await ResponseHello(request);
        }

        private Task<GreetingQueryResponse> ResponseHello(GreetingQueryRequest request)
        {
            var result = new GreetingQueryResponse();
            if (!string.IsNullOrEmpty(request.Name))
            {
                result.Message = $"{result.Message}, {request.Name}.";
            }
            return Task.FromResult(result);
        }
    }
}
