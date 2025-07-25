using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddWorkshop
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hierarchyScopeRepository"></param>
    /// <param name="hierarchyScopeContainsRelationshipRepository"></param>
    /// <param name="mediator"></param>
    public class AddAreaCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IMediator mediator) : IRequestHandler<AddAreapCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddAreapCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });

            Area area = request.ToArea();
            await hierarchyScopeRepository.AddAreaAsync(area);
            await hierarchyScopeContainsRelationshipRepository.AddAsync(area.DtId, request.SourceDtId, "区域/车间");
            area.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(area.DtId);
            return BaseResult.Ok();
        }
    }

}
