using MediatR;
using SaleProject.Application.Interfaces.Students;
using SaleProject.Infrastructure.Contexts;

namespace SaleProject.Application.Contracts.Students
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQueryRequest, List<Student>>
    {
        private readonly IStudentQueryRepository _repository;

        public GetAllStudentQueryHandler(IStudentQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Student>> Handle(GetAllStudentQueryRequest request, CancellationToken cancellationToken)
        {
            var students = await _repository.GetAllAsync();
            return students.ToList();
        }
    }

    public class GetAllStudentQueryRequest :  IRequest<List<Student>>
    {
    }
}
