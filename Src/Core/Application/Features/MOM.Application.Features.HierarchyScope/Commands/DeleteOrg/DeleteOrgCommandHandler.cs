using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.PersonnelClass;

namespace MOM.Application.Features.HierarchyScope.Commands.DeleteOrg
{
    public class DeleteOrgCommandHandler(IHierarchyScopeRepository hierarchyScopeRepository, ITranslator translator) : IRequestHandler<DeleteOrgCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteOrgCommand command, CancellationToken cancellationToken)
        {
            await hierarchyScopeRepository.DeleteAsync(command.DtIds);

            return BaseResult.Ok();
        }
    }
}
