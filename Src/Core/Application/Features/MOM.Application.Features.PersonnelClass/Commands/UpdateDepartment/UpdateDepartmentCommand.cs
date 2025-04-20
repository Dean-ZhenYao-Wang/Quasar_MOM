using MediatR;
using MOM.Application.Features.PersonnelClass.Commands.DeleteDepartment;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.PersonnelClass.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommand : DTOs.Department.Requests.UpdateDepartmentRequest, IRequest<BaseResult>
    {
    }
}
