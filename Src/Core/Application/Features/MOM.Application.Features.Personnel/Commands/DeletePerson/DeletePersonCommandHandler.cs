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
            var persons = await personRepository.GetByIdsAsync(request.DtIds);

            if (persons is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            personRepository.DeleteRange(persons);
            return BaseResult.Ok();
        }
    }
}
