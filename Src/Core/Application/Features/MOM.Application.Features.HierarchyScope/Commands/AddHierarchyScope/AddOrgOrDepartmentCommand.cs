using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope
{
    /// <summary>
    ///
    /// </summary>
    public class AddOrgOrDepartmentCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}