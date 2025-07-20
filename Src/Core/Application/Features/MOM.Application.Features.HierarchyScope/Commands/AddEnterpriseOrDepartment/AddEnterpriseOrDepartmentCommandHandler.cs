using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddEnterpriseOrDepartment
{
    public class AddEnterpriseOrDepartmentCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository,IMediator mediator) : IRequestHandler<AddEnterpriseOrDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddEnterpriseOrDepartmentCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });
            Guid thisDtId = Guid.Empty;
            switch (request.EquipmentLevel)
            {
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise:
                    Enterprise enterprise = request.ToEnterprise();
                    thisDtId = enterprise.DtId;
                    await hierarchyScopeRepository.AddEnterpriseAsync(enterprise);
                    await hierarchyScopeContainsRelationshipRepository.AddAsync(thisDtId, request.SourceDtId,"企业");
                    enterprise.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(enterprise.DtId);
                    break;
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Area:
                    Area area = request.ToArea();
                    thisDtId = area.DtId;
                    await hierarchyScopeRepository.AddDepartmentAsync(area);
                    await hierarchyScopeContainsRelationshipRepository.AddAsync(thisDtId, request.SourceDtId, "部门");
                    area.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(area.DtId);
                    break;
            }
            return BaseResult.Ok();
        }
    }
}