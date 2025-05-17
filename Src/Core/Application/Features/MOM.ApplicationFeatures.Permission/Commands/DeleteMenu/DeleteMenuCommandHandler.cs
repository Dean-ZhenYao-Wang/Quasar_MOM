using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.DeleteMenu
{
    public class DeleteMenuCommandHandler(IMenuRepository menuRepository, IButtonRepository buttonRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            using var transaction = await unitOfWork.BeginTransactionAsync();
            try
            {

                await menuRepository.DeleteAsync(request.DtIds);
                await buttonRepository.DeleteAsync(dtIds: await menuRepository.GetButtonDtIdsAsync(request.DtIds));

                await unitOfWork.CommitAsync(transaction);
            }
            catch (Exception ex)
            {
                // 回滚事务
                await unitOfWork.RollbackAsync(transaction);
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
            return BaseResult.Ok();
        }
    }
}
