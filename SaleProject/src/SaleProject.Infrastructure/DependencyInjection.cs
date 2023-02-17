using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaleProject.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using SaleProject.Application.Interfaces.Students;

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
            //services.AddMvc();
            //services.AddScoped<IDbContext, LocalDbContext>();
            services.AddScoped<IDbContext>(provider => (IDbContext)provider.GetService<LocalDbContext>());
            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));



            //services.AddScoped<IStudentQueryRepository, StudentQueryRepository>();
            // IQueryRepository<Student>

            return services;
        }
    }
}
