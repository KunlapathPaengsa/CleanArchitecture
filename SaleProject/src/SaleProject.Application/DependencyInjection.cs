using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SaleProject.Application.Contracts.Checkings.Queries;
using SaleProject.Application.Contracts.Greetings;
using SaleProject.Application.Interfaces;
using System.ComponentModel;
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


            //Add Services
            //services.AddScoped<IGreetingQueryService, GreetingQueryService>();
            //services.AddScoped<IGreetingQueryService, GreetingQueryService>();
            //services.AddSingleton<Container>();
            services.AddSingleton<IQueryProcessor, DynamicQueryProcessor>();
            return services;
        }
    }
}
