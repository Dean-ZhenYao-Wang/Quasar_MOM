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
            await menuRepository.DeleteAsync(request.DtIds);
            return BaseResult.Ok();
        }
    }
}
