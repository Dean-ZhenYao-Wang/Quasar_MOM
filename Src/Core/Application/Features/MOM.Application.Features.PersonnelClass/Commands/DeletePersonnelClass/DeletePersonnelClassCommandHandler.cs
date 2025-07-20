using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;

namespace MOM.Application.Features.PersonnelClass.Commands.DeletePersonnelClass
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="personnelClassRepository"></param>
    /// <param name="unitOfWork"></param>
    public class DeletePersonnelClassCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeletePersonnelClassCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeletePersonnelClassCommand request, CancellationToken cancellationToken)
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

            return BaseResult.Ok();
        }
    }
}