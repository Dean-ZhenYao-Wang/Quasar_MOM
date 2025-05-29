using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;

namespace MOM.Application.Features.HierarchyScope.Commands.AddOrg
{
    public class AddOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddOrgCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                var model = request.ToHierarchyScope();
                await hierarchyScopeRepository.AddAsync(model);
                await hierarchyScopeRepository.SaveChangesAsync();

                //await hierarchyScopeContainsRelationshipRepository.AddAsync(request.SourceDtId, model);

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