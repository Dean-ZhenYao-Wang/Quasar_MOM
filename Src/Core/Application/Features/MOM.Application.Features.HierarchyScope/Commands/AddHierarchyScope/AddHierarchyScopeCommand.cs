using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope
{
    public class AddHierarchyScopeCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}