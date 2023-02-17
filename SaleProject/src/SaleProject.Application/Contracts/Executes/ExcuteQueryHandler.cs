using MediatR;
using SaleProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SaleProject.Application.Contracts.Executes
{
    public class ExcuteQueryHandler : IRequestHandler<ExcuteQueryRequest, SeibelResultModel>
    {
        private readonly IQueryProcessor _queryProcessor;

        public ExcuteQueryHandler(IQueryProcessor queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }

        //public Task<SeibelResultModel> Handle(ExcuteQueryRequest request, CancellationToken cancellationToken)
        //{
        //    return Task.FromResult(GetSeibelData(request));
        //}

        private SeibelResultModel GetSeibelData(ExcuteQueryRequest request)
        {

            var query = new GetSeibelInfoQuery()
            {
                LocationCode = request.LocationCode,
                Transaction_Id = request.LocationCode,
                FullURL = "google.com"
            };

            var result = _queryProcessor.Execute(query);
            result.outStatus = "0000";
            result.outType = "Edit";
            result.outSubType = "Edit";


            return result;
        }

        public Task<SeibelResultModel> Handle(ExcuteQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(GetSeibelData(request));
        }
    }

    public class GetSeibelInfoQuery : IQuery<SeibelResultModel>
    {

        public object LocationCode { get; set; }
        public object Transaction_Id { get; set; }
        public object FullURL { get; set; }
    }

    public class SeibelResultModel
    {
        public string outStatus { get; set; }
        public string outType { get; set; }
        public string outSubType { get; set; }
    }

    public class ExcuteQueryRequest : IRequest<SeibelResultModel>
    {
        public string LocationCode { get; set; }
        //public string ASCCode { get; set; }
    }
}
