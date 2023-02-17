using Microsoft.EntityFrameworkCore;
using SaleProject.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaleProject.Application.Interfaces.Students
{
    public interface IStudentQueryRepository : IQueryRepository<Student>
    {
    }

    public interface IQueryRepository<T> where T : class
    {
        T First();

        Task<T> FirstAsync();

        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }

    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IDbContext _dbContext;

        public QueryRepository()//IDbContext dbContext)
        {
            _dbSet = _dbContext.Set<T>();
            //_dbContext = dbContext;
        }

        public T First()
        {
            return _dbSet.First();
        }

        public Task<T> FirstAsync()
        {
            return _dbSet.FirstAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsQueryable().ToListAsync();
        }

        public async Task<IQueryable<T>> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        IQueryable<T> IQueryRepository<T>.Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }

    public class StudentQueryRepository : QueryRepository<Student>, IStudentQueryRepository
    {
    }
}
