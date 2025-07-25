using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateWorkshop
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAreaCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}
