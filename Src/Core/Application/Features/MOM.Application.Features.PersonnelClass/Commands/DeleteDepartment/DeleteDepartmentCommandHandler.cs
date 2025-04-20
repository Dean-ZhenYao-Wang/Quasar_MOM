using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;

namespace MOM.Application.Features.PersonnelClass.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommandHandler(IPersonnelClassRepository personnelClassRepository, ITranslator translator) : IRequestHandler<DeleteDepartmentCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteDepartmentCommand command, CancellationToken cancellationToken)
        {
            await personnelClassRepository.DeleteAsync(command.DtIds);

            return BaseResult.Ok();
        }
    }
}
