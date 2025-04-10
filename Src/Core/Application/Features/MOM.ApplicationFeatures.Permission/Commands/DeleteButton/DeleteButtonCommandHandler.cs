using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    public class DeleteButtonCommandHandler(IMenuRepository menuRepository,IButtonRepository buttonRepository) : IRequestHandler<DeleteButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteButtonCommand request, CancellationToken cancellationToken)
        {
            await buttonRepository.ExecuteUpdateAsync(m=>request.DtIds.Contains(m.DtId), m => m.SetProperty(p => p.IsDelete, true));
            return BaseResult.Ok();
        }
    }
}
