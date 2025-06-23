using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteHierarchyScope
{
    public class DeleteHierarchyScopeCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<DeleteHierarchyScopeCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteHierarchyScopeCommand command, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await hierarchyScopeRepository.DeleteAsync(command.DtIds);

                await hierarchyScopeContainsRelationshipRepository.DeletePath(command.DtIds);

                await unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }

            return BaseResult.Ok();
        }
    }
}