using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.OrgSettingPermission
{
    public class OrgSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult>
    {
    }
}
