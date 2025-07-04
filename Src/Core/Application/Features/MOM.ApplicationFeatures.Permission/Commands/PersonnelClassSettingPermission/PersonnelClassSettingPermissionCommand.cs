﻿using MediatR;
using MOM.Application.DTOs.Permission.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission
{
    /// <summary>
    ///
    /// </summary>
    public class PersonnelClassSettingPermissionCommand : SettingPermissionRequest, IRequest<BaseResult>
    { }
}