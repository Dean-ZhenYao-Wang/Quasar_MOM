using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.AddDepartment
{
    public class AddDepartmentCommand :DTOs.Department.Requests.AddDepartmentRequest, IRequest<BaseResult>
    {
    }
}
