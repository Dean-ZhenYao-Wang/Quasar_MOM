using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.AddPerson
{
    public class AddPersonCommandHandler(IPersonRepository personRepository) : IRequestHandler<AddPersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.AddAsync(request.ToPerson());
            return BaseResult.Ok();
        }
    }
}
