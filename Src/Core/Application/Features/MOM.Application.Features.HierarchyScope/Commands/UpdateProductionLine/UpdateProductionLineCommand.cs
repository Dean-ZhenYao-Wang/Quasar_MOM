using MediatR;
using MOM.Application.DTOs.HierarchyScope.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateProductionLine
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateProductionLineCommand : UpdateOrgRequest, IRequest<BaseResult>
    {
    }
}
