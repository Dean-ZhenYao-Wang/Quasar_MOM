using MediatR;
using MOM.Application.Features.Permission.Commands.PersonnelSettingPermission;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;

namespace MOM.Application.Features.Permission.Commands.PositionSettingPermission
{
    public class PersonnelSettingPermissionCommandHandler(IAvailablePermissionRepository availablePermissionRepository, IUnitOfWork unitOfWork) : IRequestHandler<PersonnelSettingPermissionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(PersonnelSettingPermissionCommand request, CancellationToken cancellationToken)
        {
            List<AvailablePermission> c = await availablePermissionRepository.GetByOwnerAsync(request.Owner);

            // A中有但B中没有的元素,需要删除的权限
            List<string> aNotInB = request.oldMenuButtonIds.Except(request.menuButtonIds).ToList();
            foreach (var a in aNotInB)
            {
                var cItem = c.FirstOrDefault(m => m.MenuButtonId == a);
                if (cItem == null)
                {
                    await availablePermissionRepository.AddAsync(new AvailablePermission()
                    {
                        MenuButtonId = a,
                        Available = false,
                        PersonDtId = request.Owner
                    });
                }
                else if (cItem.Available)
                {
                    cItem.Available = false;
                }
            }

            // B中有但A中没有的元素，需要添加的权限
            List<string> bNotInA = request.menuButtonIds.Except(request.oldMenuButtonIds).ToList();
            foreach (var b in bNotInA)
            {
                var cItem = c.FirstOrDefault(m => m.MenuButtonId == b);
                if (cItem == null)
                {
                    await availablePermissionRepository.AddAsync(new AvailablePermission()
                    {
                        MenuButtonId = b,
                        Available = true,
                        PersonDtId = request.Owner
                    });
                }
                else if (cItem.Available == false)
                {
                    cItem.Available = true;
                }
            }

            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}