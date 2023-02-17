using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaleProject.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace SaleProject.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)//, IConfiguration Configuration)
        {
            //services.AddTransient<IRequestHandler<CheckingQueryRequest, CheckingQueryResponse>, CheckingQueryHandler>();
            var connectionString = configuration.GetConnectionString("LocalDBConnection");
            services.AddDbContext<LocalDbContext>(option => option.UseSqlServer(connectionString));

            //Add DbContext
            return services;
        }
    }
}
