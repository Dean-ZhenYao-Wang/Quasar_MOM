using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateProductionUnit
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="translator"></param>
    /// <param name="unitOfWork"></param>
    public class UpdateProductionUnitCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductionUnitCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateProductionUnitCommand request, CancellationToken cancellationToken)
        {
            ProductionUnit productionUnit = await hierarchyScopeRepository.GetProductionUnitByKeyAsync(request.DtId);
            if (productionUnit is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }
            productionUnit.Update(request.ToHierarchyScope());
            if (request.SourceDtId == null)
                productionUnit.FullPath = productionUnit.Name;
            if (productionUnit.SourceDtId != null)
            {
                await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "工段/工位");
                productionUnit.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(productionUnit.DtId);
            }
            return BaseResult.Ok();
        }
    }
}
