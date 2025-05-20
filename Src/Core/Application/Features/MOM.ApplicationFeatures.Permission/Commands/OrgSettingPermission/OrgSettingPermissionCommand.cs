using MediatR;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.OrgSettingPermission
{
    public class OrgSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult>
    {
    }
}