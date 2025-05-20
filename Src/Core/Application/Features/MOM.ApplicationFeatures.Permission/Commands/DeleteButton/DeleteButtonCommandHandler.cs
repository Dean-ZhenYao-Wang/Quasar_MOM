using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    public class DeleteButtonCommandHandler(IButtonRepository buttonRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteButtonCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {
                await buttonRepository.DeleteAsync(request.DtIds);
                await unitOfWork.CommitAsync(transaction);
            }
            catch (Exception ex)
            {
                await unitOfWork.RollbackAsync(transaction);
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
            return BaseResult.Ok();
        }
    }
}