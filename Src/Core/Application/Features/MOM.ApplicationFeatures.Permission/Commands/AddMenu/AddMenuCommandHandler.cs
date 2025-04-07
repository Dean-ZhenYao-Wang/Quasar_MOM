using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.AddMenu
{
    public class AddMenuCommandHandler(IMenuRepository menuRepository) : IRequestHandler<AddMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddMenuCommand request, CancellationToken cancellationToken)
        {
            var addMenu = request.ToMenu();
            await menuRepository.AddAsync(addMenu);
            return BaseResult.Ok();
        }
    }
}
