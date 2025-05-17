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
            var model = request.ToHierarchyScope();
            await hierarchyScopeRepository.AddAsync(model);

            await hierarchyScopeContainsRelationshipRepository.AddAsync(new HierarchyScopeContainsRelationship(request.SourceDtId, model.DtId));

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
