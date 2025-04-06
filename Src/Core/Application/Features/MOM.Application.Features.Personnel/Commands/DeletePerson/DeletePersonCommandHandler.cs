using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.DeletePerson
{
    public class DeletePersonCommandHandler(IPersonRepository personRepository, ITranslator translator) : IRequestHandler<DeletePersonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.ExecuteUpdateAsync(m => request.DtIds.Contains(m.DtId), m => m.SetProperty(m => m.IsDelete, true));
            return BaseResult.Ok();
        }
    }
}
