using SimpleInjector;

namespace SaleProject.Application.Interfaces
{
    public class DynamicQueryProcessor : IQueryProcessor
    {
        private readonly Container container;
        private readonly IServiceProvider _serviceProvider;

        //public DynamicQueryProcessor(Container container)
        //{
        //    this.container = container;
        //}

        public DynamicQueryProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));

            dynamic handler = _serviceProvider.GetService(handlerType);

            return handler.Handle((dynamic)query);
        }
    }

    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
