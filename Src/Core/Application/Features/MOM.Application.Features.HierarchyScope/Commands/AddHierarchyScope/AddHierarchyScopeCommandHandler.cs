using MediatR;
using MOM.Application.DTOs.CodingRule.Requests;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope
{
    public class AddHierarchyScopeCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<AddHierarchyScopeCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddHierarchyScopeCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                if (string.IsNullOrWhiteSpace(request.Id))
                    request.Id = await mediator.Send(new GenerateCodeCommand { RuleId = "HierarchyScopeId", ModelTypeName = "MOM.Domain.isa95.CommonObjectModels.HierarchyScope,MOM.Domain" });
                Enterprise model = request.ToEnterprise();

                if(request.EquipmentLevel== Domain.Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise)
                {
                    await unitOfWork.DbContext.Set<Enterprise>().AddAsync(model);
                }

               // await hierarchyScopeRepository.AddAsync(model);
                await unitOfWork.SaveChangesAsync();
                await hierarchyScopeRepository.AddAsync(model as Domain.isa95.CommonObjectModels.HierarchyScope);
                await hierarchyScopeContainsRelationshipRepository.AddAsync(model.DtId, request.SourceDtId);
                await hierarchyScopeContainsRelationshipRepository.SaveChangesAsync();

                if (model.SourceDtId != null)
                {
                    model.FullPath = await hierarchyScopeContainsRelationshipRepository.GetPathAsync(model.DtId);
                }

                await unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await unitOfWork.RollbackAsync();
                throw;
            }
            return BaseResult.Ok();
        }
    }
}