﻿using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Permission.Commands.AddMenu
{
    /// <summary>
    ///
    /// </summary>
    public class AddMenuCommand : AddMenuRequest, IRequest<BaseResult>
    {
    }
}