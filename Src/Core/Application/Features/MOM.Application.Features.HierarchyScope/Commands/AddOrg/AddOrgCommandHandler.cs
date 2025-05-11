using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.AddOrg
{
    public class AddOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddOrgCommand request, CancellationToken cancellationToken)
        {
            var model = request.ToHierarchyScope();
            await hierarchyScopeRepository.AddAsync(model,request.SourceDtId);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
