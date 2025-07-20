using MediatR;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteMenu
{
    public class DeleteMenuCommandHandler(IMenuRepository menuRepository, IButtonRepository buttonRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            await menuRepository.DeleteAsync(request.DtIds);
            await buttonRepository.DeleteAsync(dtIds: await menuRepository.GetButtonDtIdsAsync(request.DtIds));
            return BaseResult.Ok();
        }
    }
}