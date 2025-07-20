using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteHierarchyScope
{
    public class DeleteHierarchyScopeCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<DeleteHierarchyScopeCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteHierarchyScopeCommand command, CancellationToken cancellationToken)
        {
            await hierarchyScopeRepository.DeleteAsync(command.DtIds);

            await hierarchyScopeContainsRelationshipRepository.DeletePathAsync(command.DtIds);

            return BaseResult.Ok();
        }
    }
}