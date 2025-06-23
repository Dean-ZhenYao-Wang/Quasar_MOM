using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.DeletePerson
{
    /// <summary>
    ///
    /// </summary>
    public class DeletePersonCommandHandler(IPersonRepository personRepository) : IRequestHandler<DeletePersonCommand, BaseResult>
    {
        /// <summary>
        ///
        /// </summary>
        public async Task<BaseResult> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.DeleteAsync(request.DtIds);
            return BaseResult.Ok();
        }
    }
}