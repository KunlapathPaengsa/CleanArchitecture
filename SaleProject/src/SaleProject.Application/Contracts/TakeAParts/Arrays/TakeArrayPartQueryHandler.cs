using MediatR;

namespace SaleProject.Application.Contracts.TakeAParts.Arrays
{
    public partial class TakeArrayPartQueryHandler : IRequestHandler<TakeArrayPartQueryRequest, string[]>
    {
        public Task<string[]> Handle(TakeArrayPartQueryRequest request, CancellationToken cancellationToken)
        {
            var result = new string[] { };
            if (request.IsValue)
            {
                result = Enum.GetNames(typeof(VehicleData));
            }
            else
            {
                result = Enum.GetValues(typeof(VehicleData)).Cast<int>().Select(value => value.ToString()).ToArray();
            }
            return Task.FromResult(result);
        }
    }
}
