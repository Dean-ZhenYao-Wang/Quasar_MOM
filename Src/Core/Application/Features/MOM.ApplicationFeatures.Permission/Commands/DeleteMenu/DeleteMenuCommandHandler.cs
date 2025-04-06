using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.ApplicationFeatures.Permission.Commands.DeleteMenu
{
    public class DeleteMenuCommandHandler(IMenuRepository menuRepository,IButtonRepository buttonRepository) : IRequestHandler<DeleteMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            await menuRepository.ExecuteUpdateAsync(m => request.DtIds.Contains(m.DtId), m => m.SetProperty(p => p.IsDelete, true));
            await buttonRepository.ExecuteUpdateAsync(m=>request.DtIds.Contains(m.MenuDtId), m => m.SetProperty(p => p.IsDelete, true));
            return BaseResult.Ok();
        }
    }
}
