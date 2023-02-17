using MediatR;
using SaleProject.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleProject.Application.Contracts.Students
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQueryRequest, List<Student>>
    {
        public Task<List<Student>> Handle(GetAllStudentQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new List<Student>());
        }
    }

    public class GetAllStudentQueryRequest :  IRequest<List<Student>>
    {
        //public string Temp { get; set; }
    }
}
