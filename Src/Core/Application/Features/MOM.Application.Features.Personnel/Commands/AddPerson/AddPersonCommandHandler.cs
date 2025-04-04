using MediatR;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandHandler(IPersonRepository personRepository) : IRequestHandler<AddPersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            Person addPerson = request.ToPerson();
            addPerson.PassWord = "123456".Sha1Signature().Sha1Signature(addPerson.DtId.ToString());
            await personRepository.AddAsync(addPerson);
            return BaseResult.Ok();
        }
    }
}
