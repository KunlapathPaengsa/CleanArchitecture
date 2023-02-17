using Microsoft.EntityFrameworkCore;

namespace SaleProject.Infrastructure.Contexts
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
