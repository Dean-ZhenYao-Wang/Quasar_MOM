using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.Common;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Commands.DeletePosition
{
    public class DeletePositionCommand : DeleteCommand
    {
    }
    public class DeletePositionCommandHandler(IPersonnelClassRepository personnelClassRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeletePositionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeletePositionCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await personnelClassRepository.DeleteAsync(request.DtIds);

                await unitOfWork.Relationships.Set<PersonnelClassIncludesPropertiesOfRelationship >()
                    .Where(m => request.DtIds.Contains(m.SourceId.Value))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.Relationships.Set<PersonnelClassHasPropertiesOfRelationship>()
                    .Where(m => request.DtIds.Contains(m.DtId))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(p => p.IsDelete, true));

                await unitOfWork.Relationships.Set<PersonnelClassHierarchyScopeRelRelationship>()
                    .Where(m => request.DtIds.Contains(m.DtId))
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
