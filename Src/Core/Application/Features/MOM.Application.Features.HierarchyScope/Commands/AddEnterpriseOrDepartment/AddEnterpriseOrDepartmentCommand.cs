using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddEnterpriseOrDepartment
{
    /// <summary>
    ///
    /// </summary>
    public class AddEnterpriseOrDepartmentCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}