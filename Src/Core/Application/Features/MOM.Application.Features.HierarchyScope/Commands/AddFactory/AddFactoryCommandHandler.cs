using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="unitOfWork"></param>
    /// <param name="mediator"></param>
    public class AddFactoryCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IMediator mediator) : IRequestHandler<AddFactoryCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddFactoryCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });

            Site site = request.ToSite();
            await hierarchyScopeRepository.AddFactoryAsync(site);
            await hierarchyScopeContainsRelationshipRepository.AddAsync(site.DtId, request.SourceDtId, "工厂");
            site.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(site.DtId);
            return BaseResult.Ok();
        }
    }
}
