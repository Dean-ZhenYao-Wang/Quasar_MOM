using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.UpdateButton
{
    public class UpdateButtonCommandHandler(IButtonRepository buttonRepository,ITranslator translator) : IRequestHandler<UpdateButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(UpdateButtonCommand request, CancellationToken cancellationToken)
        {
            var button = await buttonRepository.GetByIdAsync(request.DtId);

            if (button is null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.NotFound()));
            }

            button.Update(request.Id, request.Name, request.Icon);
            return BaseResult.Ok();
        }
    }
}
