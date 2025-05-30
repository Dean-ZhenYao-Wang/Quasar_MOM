﻿using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.Features.Personnel.Commands.Authentication;
using MOM.Application.Features.Personnel.Commands.ChangePassword;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 人员认证管理.Controllers.v1
{
    [Tags("账号登录和密码修改")]
    [ApiVersion("1")]
    public class AccountController : BaseApiController
    {
        /// <summary>
        /// 账号登录
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 密码修改成功需要重新登录
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> ChangePassword(ChangePasswordCommand command)
        {
            var result = await Mediator.Send(command);
            return result;
        }
    }
}