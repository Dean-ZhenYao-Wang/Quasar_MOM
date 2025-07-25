using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddProductionUnit
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="mediator"></param>
    public class AddProductionUnitCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IMediator mediator) : IRequestHandler<AddProductionUnitCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddProductionUnitCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });

            ProductionUnit productionUnit = request.ToProductionUnit();
            await hierarchyScopeRepository.AddProductionUnitAsync(productionUnit);
            await hierarchyScopeContainsRelationshipRepository.AddAsync(productionUnit.DtId, request.SourceDtId, "工段/工位");
            productionUnit.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(productionUnit.DtId);
            return BaseResult.Ok();
        }
    }

}
