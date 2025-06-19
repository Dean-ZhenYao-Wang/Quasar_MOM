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

                if (await unitOfWork.DbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.SourceId)).AnyAsync())
                {
                    throw new ApplicationException("存在拥有下属人员分类的人员分类，无法删除");
                }

                await unitOfWork.DbContext.Set<PersonnelClassIncludesPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.TargetId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.DbContext.Set<PersonnelClassHierarchyScopeRelRelationship>()
                    .Where(m => request.DtIds.Contains(m.SourceId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.CommitAsync();

                return BaseResult.Ok();
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync();
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }
    }
}