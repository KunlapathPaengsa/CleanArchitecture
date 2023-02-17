using System.Threading.Tasks;

namespace SaleProject.Application.Interfaces
{
    public interface IQueryProcessor
    {
        TResult Execute<TResult>(IQuery<TResult> query);
    }
    public interface IQueryProcessorAsync
    {
        Task<TResult> ExecuteAsync<TResult>(IQuery<TResult> query);
    }

    public interface IQuery<TResult>
    {
    }
}