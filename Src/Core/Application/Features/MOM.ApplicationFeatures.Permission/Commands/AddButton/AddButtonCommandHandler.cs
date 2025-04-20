using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    public class AddButtonCommandHandler(IButtonRepository buttonRepository,IUnitOfWork unitOfWork) : IRequestHandler<AddButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddButtonCommand request, CancellationToken cancellationToken)
        {
            var addButton = request.ToButton();
            await buttonRepository.AddAsync(addButton);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
