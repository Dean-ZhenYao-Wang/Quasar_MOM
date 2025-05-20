using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddOrg
{
    public class AddOrgCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}