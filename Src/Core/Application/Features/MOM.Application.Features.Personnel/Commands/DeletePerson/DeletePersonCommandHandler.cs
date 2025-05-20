using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.DeletePerson
{
    public class DeletePersonCommandHandler(IPersonRepository personRepository, ITranslator translator) : IRequestHandler<DeletePersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.DeleteAsync(request.DtIds);
            return BaseResult.Ok();
        }
    }
}