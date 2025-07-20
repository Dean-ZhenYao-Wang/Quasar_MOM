using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    public class DeleteButtonCommandHandler(IButtonRepository buttonRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteButtonCommand request, CancellationToken cancellationToken)
        {
            await buttonRepository.DeleteAsync(request.DtIds);
            return BaseResult.Ok();
        }
    }
}