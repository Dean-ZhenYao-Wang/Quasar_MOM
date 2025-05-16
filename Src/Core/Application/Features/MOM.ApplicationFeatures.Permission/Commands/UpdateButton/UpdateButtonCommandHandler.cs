using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateButton
{
    public class UpdateButtonCommandHandler(IButtonRepository buttonRepository, IMenuRepository menuRepository, ITranslator translator, IUnitOfWork unitOfWork) : IRequestHandler<UpdateButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateButtonCommand request, CancellationToken cancellationToken)
        {
            var button = await buttonRepository.GetByIdAsync(request.DtId);

            if (button is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            if (buttonRepository.Where(m => m.DtId != request.DtId && m.Id.Equals(request.Id)).Any() || menuRepository.Where(m => m.Id.Equals(request.Id)).Any())
                throw new ApplicationException("按钮编号必须唯一");

            button.Update(request.Id, request.Name, request.Icon);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
