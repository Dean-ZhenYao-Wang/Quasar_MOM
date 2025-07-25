using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddWorkshop
{
    /// <summary>
    /// 
    /// </summary>
    public class AddAreapCommand : AddOrgRequest, IRequest<BaseResult>
    {
    }
}
