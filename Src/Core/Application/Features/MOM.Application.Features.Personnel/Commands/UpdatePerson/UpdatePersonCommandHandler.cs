using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Common.Relationship.isa95.Person;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace MOM.Application.Features.Personnel.Commands.UpdatePerson
{
    public class UpdatePersonCommandHandler(IPersonRepository personRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdatePersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = await personRepository.DbSet
                .Include(p => p.DefinedBy)
                .ThenInclude(d => d.Target)
                .Include(p => p.HierarchyScopeRel)
                .Where(p => p.DtId == request.DtId)
                .AsSplitQuery()
                .FirstOrDefaultAsync();

            if (person is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            person.Update(request.Id, request.Name, request.WorkStatus, request.Email, request.PhoneNumber, request.TeamDtId, request.OrgDtId, request.PositionDtId_List, request.Description);

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}