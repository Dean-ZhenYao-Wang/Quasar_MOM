using MediatR;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.PersonnelSettingPermission
{
    public class PersonnelSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult>
    {
        /// <summary>
        /// 原始的菜单或按钮的DtId清单
        /// </summary>
        public List<string> oldMenuButtonIds { get; set; } = new List<string>();
    }
}