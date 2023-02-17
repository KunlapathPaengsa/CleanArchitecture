using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleProject.Application.Contracts.Middles
{
    public class MiddleQueryRequest : IRequest<MiddleQueryResponse>// MiddleQueryRequest<TResult> MiddleQueryResponse<TResult>>
    {
        public string ClassName { get; set; }
        public string Param { get; set; }
    }

    public class MiddleQueryResponse//<TResult>
    {
        public string Response { get;}
    }

    public class MiddleQueryHandler : IRequestHandler<MiddleQueryRequest, MiddleQueryResponse>
    {
        public Task<MiddleQueryResponse> Handle(MiddleQueryRequest request, CancellationToken cancellationToken)
        {
            MiddleQueryResponse result = CallProvider(request);
            return  Task.FromResult(new  MiddleQueryResponse());
        }

        private MiddleQueryResponse CallProvider(MiddleQueryRequest request)
        {
            Type type = Type.GetType(request.ClassName);
            return new MiddleQueryResponse();
        }
    }

}
