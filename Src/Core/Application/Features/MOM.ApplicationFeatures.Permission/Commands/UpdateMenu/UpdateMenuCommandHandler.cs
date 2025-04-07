using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateMenu
{
    public class UpdateMenuCommandHandler(IMenuRepository menuRepository, ITranslator translator) : IRequestHandler<UpdateMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await menuRepository.GetByIdAsync(request.DtId);

            if (menu is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            menu.Update(request.Id, request.Name, request.Path, request.Description, request.Icon, request.Hidden, request.AlwaysShow, request.Depth);
            return BaseResult.Ok();
        }
    }
}
