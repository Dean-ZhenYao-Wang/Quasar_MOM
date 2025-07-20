using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.UpdateEnterpriseOrDepartment
{
    public class UpdateEnterpriseOrDepartmentCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateEnterpriseOrDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateEnterpriseOrDepartmentCommand request, CancellationToken cancellationToken)
        {
            switch (request.EquipmentLevel)
            {
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise:
                    var enterprise = await hierarchyScopeRepository.GetEnterpriseByKeyAsync(request.DtId);
                    if (enterprise is null)
                    {
                        return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
                    }
                    enterprise.Update(request.ToHierarchyScope());
                    if (request.SourceDtId == null)
                        enterprise.FullPath = enterprise.Name;
                    if (enterprise.SourceDtId != null)
                    {
                        await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "企业");
                        enterprise.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(enterprise.DtId);
                    }
                    break;
                case Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Area:
                    var area = await hierarchyScopeRepository.GetAreaByKeyAsync(request.DtId);
                    if (area is null)
                    {
                        return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
                    }
                    area.Update(request.ToHierarchyScope());
                    if (request.SourceDtId == null)
                        area.FullPath = area.Name;
                    if (area.SourceDtId != null)
                    {
                        await hierarchyScopeContainsRelationshipRepository.MoveNodeAsync(request.DtId, request.SourceDtId, "部门");
                        area.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(area.DtId);
                    }
                    break;
            }
            return BaseResult.Ok();
        }
    }
}