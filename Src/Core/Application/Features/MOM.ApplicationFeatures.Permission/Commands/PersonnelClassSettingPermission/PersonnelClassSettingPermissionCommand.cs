using MediatR;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Features.Permission.Commands.OrgSettingPermission;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission
{
    public class PersonnelClassSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult> { }
}
