using MediatR;
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
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)//, IConfiguration Configuration)
        {
            //services.AddTransient<IRequestHandler<CheckingQueryRequest, CheckingQueryResponse>, CheckingQueryHandler>();

            //Add MediatR
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
