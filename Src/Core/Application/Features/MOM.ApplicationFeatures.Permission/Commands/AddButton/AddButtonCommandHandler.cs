using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddButton
{
    public class AddButtonCommandHandler(IButtonRepository buttonRepository, IMenuRepository menuRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddButtonCommand request, CancellationToken cancellationToken)
        {
            if (menuRepository.Where(m => m.Id.Equals(request.Id)).Any()||buttonRepository.Where(m => m.Id.Equals(request.Id)).Any())
            {
                throw new ApplicationException("按钮编号必须唯一");
            }
            var addButton = request.ToButton();
            await buttonRepository.AddAsync(addButton);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
