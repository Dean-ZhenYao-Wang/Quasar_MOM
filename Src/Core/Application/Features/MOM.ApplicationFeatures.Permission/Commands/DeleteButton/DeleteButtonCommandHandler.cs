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

namespace MOM.Application.Features.Permission.Commands.DeleteButton
{
    public class DeleteButtonCommandHandler(IButtonRepository buttonRepository) : IRequestHandler<DeleteButtonCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(DeleteButtonCommand request, CancellationToken cancellationToken)
        {
            await buttonRepository.DeleteAsync(request.DtIds);
            return BaseResult.Ok();
        }
    }
}
