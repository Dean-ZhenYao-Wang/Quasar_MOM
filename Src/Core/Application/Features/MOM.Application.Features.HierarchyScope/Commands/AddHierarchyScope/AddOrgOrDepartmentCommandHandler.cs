using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope
{
    public class AddOrgOrDepartmentCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddOrgOrDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddOrgOrDepartmentCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });

            switch (request.EquipmentLevel)
            {
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise:
                    Enterprise enterprise = request.ToEnterprise();
                    await hierarchyScopeRepository.AddAsync(enterprise);
                    enterprise.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(enterprise.DtId);
                    break;
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Area:
                    Area area = request.ToArea();
                    await hierarchyScopeRepository.AddAsync(area);
                    area.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(area.DtId);
                    break;
            }

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}