using MediatR;
using MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.PositionSettingPermission
{
    public class PersonnelClassSettingPermissionCommandHandlerr(IPersonnelClassPermissionRepository personnelClassPermissionRepository, IUnitOfWork unitOfWork) : IRequestHandler<PersonnelClassSettingPermissionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(PersonnelClassSettingPermissionCommand request, CancellationToken cancellationToken)
        {
            List<string> dbMenuButtonIds = await personnelClassPermissionRepository.GetByOwnerAsync(request.Owner);
            if (dbMenuButtonIds.Count == 0)
            {
                await personnelClassPermissionRepository.AddRangeAsync(request.menuButtonIds, request.Owner);
            }
            else
            {
                // A中有但B中没有的元素,需要删除的权限
                List<string> aNotInB = dbMenuButtonIds.Except(request.menuButtonIds).ToList();
                personnelClassPermissionRepository.Delete(aNotInB, request.Owner);

                // B中有但A中没有的元素，需要添加的权限
                List<string> bNotInA = request.menuButtonIds.Except(dbMenuButtonIds).ToList();
                await personnelClassPermissionRepository.AddRangeAsync(bNotInA, request.Owner);
            }
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}