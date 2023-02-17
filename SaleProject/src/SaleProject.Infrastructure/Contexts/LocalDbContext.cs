using Microsoft.EntityFrameworkCore;

namespace SaleProject.Infrastructure.Contexts
{
    public class LocalDbContext : ILocalDbContext
    {
        public LocalDbContext(DbContextOptions options) //: base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
    public interface ILocalDbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
