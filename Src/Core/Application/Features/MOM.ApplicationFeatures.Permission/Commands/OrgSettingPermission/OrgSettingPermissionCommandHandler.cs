using MediatR;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.OrgSettingPermission
{
    public class OrgSettingPermissionCommandHandlerr(IOrgPermissionRepository orgPermissionRepository, IUnitOfWork unitOfWork) : IRequestHandler<OrgSettingPermissionCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(OrgSettingPermissionCommand request, CancellationToken cancellationToken)
        {
            List<string> dbMenuButtonIds = await orgPermissionRepository.GetOrgPermissionListAsync(request.Owner);
            if (dbMenuButtonIds.Count == 0)
            {
                await orgPermissionRepository.AddRangeAsync(request.menuButtonIds, request.Owner);
            }
            else
            {
                // A中有但B中没有的元素,需要删除的权限
                List<string> aNotInB = dbMenuButtonIds.Except(request.menuButtonIds).ToList();
                orgPermissionRepository.Delete(aNotInB, request.Owner);

                // B中有但A中没有的元素，需要添加的权限
                List<string> bNotInA = request.menuButtonIds.Except(dbMenuButtonIds).ToList();
                await orgPermissionRepository.AddRangeAsync(bNotInA, request.Owner);
            }
            await unitOfWork.SaveChangesAsync();
            return BaseResult.Ok();
        }
    }
}