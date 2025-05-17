using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.AddMenu
{
    public class AddMenuCommandHandler(IMenuRepository menuRepository, IButtonRepository buttonRepository, IUnitOfWork unitOfWork) : IRequestHandler<AddMenuCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(AddMenuCommand request, CancellationToken cancellationToken)
        {
            if (buttonRepository.Where(m => m.Id.Equals(request.Id)).Any() || menuRepository.Where(m => m.DtId != entity.DtId && m.Id.Equals(request.Id)).Any())
                throw new ApplicationException("菜单编号必须唯一");
            var addMenu = request.ToMenu();
            await menuRepository.AddAsync(addMenu);
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}
