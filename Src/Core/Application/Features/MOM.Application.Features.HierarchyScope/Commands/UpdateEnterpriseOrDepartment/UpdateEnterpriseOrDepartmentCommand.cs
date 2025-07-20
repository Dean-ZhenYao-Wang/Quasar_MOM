using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateEnterpriseOrDepartment
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateEnterpriseOrDepartmentCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}