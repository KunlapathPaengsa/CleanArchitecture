using Microsoft.EntityFrameworkCore;

namespace SaleProject.Application.Interfaces.Students
{
    public  interface IDbContext:  IDisposable
    {
        DbSet<T> Set<T>() where T : class;

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}