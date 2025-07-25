using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateProductionUnit
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateProductionUnitCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}
