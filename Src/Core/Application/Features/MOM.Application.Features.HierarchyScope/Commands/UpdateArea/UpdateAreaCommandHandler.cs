using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateWorkshop
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="translator"></param>
    /// <param name="unitOfWork"></param>
    public class UpdateAreaCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateAreaCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            Area area = await hierarchyScopeRepository.GetAreaByKeyAsync(request.DtId);
            if (area is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }
            area.Update(request.ToHierarchyScope());
            if (request.SourceDtId == null)
                area.FullPath = area.Name;
            if (area.SourceDtId != null)
            {
                await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "区域/车间");
                area.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(area.DtId);
            }
            return BaseResult.Ok();
        }
    }
}
