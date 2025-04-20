using MediatR;
using MOM.Application.Wrappers;
using static System.Net.WebRequestMethods;

namespace MOM.Application.Features.PersonnelClass.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommand : IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}
