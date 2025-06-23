using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateHierarchyScope
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateHierarchyScopeCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}