using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;

namespace MOM.Application.Features.PersonnelClass.Commands.DeletePosition
{
    public class DeletePersonnelClassCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeletePersonnelClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeletePersonnelClassCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await personnelClassRepository.DeleteAsync(request.DtIds);

                if (await unitOfWork.Relationships.Set<PersonnelClassIncludesPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.SourceId.Value)).AnyAsync())
                {
                    throw new ApplicationException("存在拥有下属人员分类的人员分类，无法删除");
                }


                await unitOfWork.Relationships.Set<PersonnelClassIncludesPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.TargetId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.Relationships.Set<PersonnelClassHasPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.SourceId.Value))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.Relationships.Set<PersonnelClassHierarchyScopeRelRelationship>()
                    .Where(m => request.DtIds.Contains(m.SourceId.Value))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.CommitAsync(transaction);

                return BaseResult.Ok();
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync(transaction);
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }
    }
}
