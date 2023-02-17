using MediatR;

namespace SaleProject.Application.Contracts.TakeAParts.Arrays
{
    public partial class TakeArrayPartQueryHandler : IRequestHandler<TakeArrayPartQueryRequest, string[]>
    {
        public Task<string[]> Handle(TakeArrayPartQueryRequest request, CancellationToken cancellationToken)
        {
            return GetVehicleData(request.IsValue);
            
        }

        private Task<string[]> GetVehicleData(bool isValue)
        {
            var result = Enum.GetNames(typeof(VehicleData));
            if (!isValue)
            {
                result = Enum.GetValues(typeof(VehicleData)).Cast<int>().Select(value => value.ToString()).ToArray();
            }
            return Task.FromResult(result);
        }
    }
}
