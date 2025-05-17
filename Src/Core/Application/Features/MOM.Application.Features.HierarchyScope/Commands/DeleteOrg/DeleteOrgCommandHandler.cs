using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteOrg
{
    public class DeleteOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, IHierarchyScopeContainsRelationshipRepository hierarchyScopeContainsRelationshipRepository, ITranslator translator,IUnitOfWork unitOfWork) : IRequestHandler<DeleteOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteOrgCommand command, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await hierarchyScopeRepository.DeleteAsync(command.DtIds);

                await hierarchyScopeContainsRelationshipRepository
                    .Where(m => command.DtIds.Contains(m.SourceId.Value) || command.DtIds.Contains(m.TargetId))
                    .AsQueryable()
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.CommitAsync(transaction);
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync(transaction);
                throw new ApplicationException(ex.Message, ex.InnerException);
            }

            return BaseResult.Ok();
        }
    }
}
