using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateProductionLine
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="translator"></param>
    /// <param name="unitOfWork"></param>
    public class UpdateProductionLineCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductionLineCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateProductionLineCommand request, CancellationToken cancellationToken)
        {
            ProductionLine productionLine = await hierarchyScopeRepository.GetProductionLineByKeyAsync(request.DtId);
            if (productionLine is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }
            productionLine.Update(request.ToHierarchyScope());
            if (request.SourceDtId == null)
                productionLine.FullPath = productionLine.Name;
            if (productionLine.SourceDtId != null)
            {
                await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "产线");
                productionLine.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(productionLine.DtId);
            }
            return BaseResult.Ok();
        }
    }
}
