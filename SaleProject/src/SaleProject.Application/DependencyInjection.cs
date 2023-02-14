using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SaleProject.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)//, IConfiguration Configuration)
        {
            //Add MediatR
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddTransient<IRequestHandler<CheckingQueryRequest, CheckingQueryResponse>, CheckingQueryHandler>();
            return services;
        }
    }
}
