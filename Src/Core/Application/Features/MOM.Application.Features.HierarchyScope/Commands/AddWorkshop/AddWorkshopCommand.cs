using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddWorkshop
{
    /// <summary>
    /// 
    /// </summary>
    public class AddWorkshopCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}
