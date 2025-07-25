using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddProductionLine
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="mediator"></param>
    public class AddProductionLineCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IMediator mediator) : IRequestHandler<AddProductionLineCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddProductionLineCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });

            ProductionLine productionLine = request.ToProductionLine();
            await hierarchyScopeRepository.AddProductionLineAsync(productionLine);
            await hierarchyScopeContainsRelationshipRepository.AddAsync(productionLine.DtId, request.SourceDtId, "产线");
            productionLine.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(productionLine.DtId);
            return BaseResult.Ok();
        }
    }

}
