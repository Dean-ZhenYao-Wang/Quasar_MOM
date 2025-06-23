using MediatR;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.OrgSettingPermission
{
    /// <summary>
    ///
    /// </summary>
    public class OrgSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult>
    {
    }
}