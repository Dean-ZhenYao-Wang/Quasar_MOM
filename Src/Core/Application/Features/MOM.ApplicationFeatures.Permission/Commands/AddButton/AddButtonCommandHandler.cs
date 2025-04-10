using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    public class AddButtonCommandHandler(IButtonRepository buttonRepository) : IRequestHandler<AddButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddButtonCommand request, CancellationToken cancellationToken)
        {
            var addButton = request.ToButton();
            await buttonRepository.AddAsync(addButton);
            return BaseResult.Ok();
        }
    }
}
