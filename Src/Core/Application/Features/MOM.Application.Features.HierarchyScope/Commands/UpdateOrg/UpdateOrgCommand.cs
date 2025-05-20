using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateOrg
{
    public class UpdateOrgCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}