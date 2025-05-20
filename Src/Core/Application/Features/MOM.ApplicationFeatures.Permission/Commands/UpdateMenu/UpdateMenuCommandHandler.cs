using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateMenu
{
    public class UpdateMenuCommandHandler(IMenuRepository menuRepository, IButtonRepository buttonRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await menuRepository.GetByIdAsync(request.DtId);

            if (menu is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            if (buttonRepository.Where(m => m.Id.Equals(request.Id)).Any() || menuRepository.Where(m => m.DtId != request.DtId && m.Id.Equals(request.Id)).Any())
                throw new ApplicationException("菜单编号必须唯一");

            menu.Update(request.Id, request.Name, request.Path, request.Description, request.Icon, request.Hidden, request.AlwaysShow, request.Depth);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}