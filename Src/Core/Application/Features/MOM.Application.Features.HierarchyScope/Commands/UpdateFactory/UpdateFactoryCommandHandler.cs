using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="translator"></param>
    /// <param name="unitOfWork"></param>
    public class UpdateFactoryCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateFactoryCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateFactoryCommand request, CancellationToken cancellationToken)
        {
            Site site = await hierarchyScopeRepository.GetSiteByKeyAsync(request.DtId);
            if (site is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }
            site.Update(request.ToHierarchyScope());
            if (request.SourceDtId == null)
                site.FullPath = site.Name;
            if (site.SourceDtId != null)
            {
                await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "工厂");
                site.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(site.DtId);
            }
            return BaseResult.Ok();
        }
    }
}
