using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SaleProject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)//, IConfiguration Configuration)
        {
            //services.AddTransient<IRequestHandler<CheckingQueryRequest, CheckingQueryResponse>, CheckingQueryHandler>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            //Add MediatR
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
